using AltV.Net;
using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using Microsoft.EntityFrameworkCore;
using transport.domain.core;
using transport.domain.core.Controlled.dto;
using transport.domain.core.Mechanical;
using transport.domain.core.Mechanical.dto;
using transport.domain.core.Mechanical.modules.Battery;
using transport.domain.core.Mechanical.modules.Engine;
using transport.domain.core.Mechanical.modules.Petrol;
using transport.domain.core.Overland;
using transport.domain.core.Overland.dto;
using transport.domain.core.Overland.modules.Axis;
using transport.domain.core.Transport.dto;
using transport.domain.core.Truck.dto;
using transport.domain.core.Wagon;
using transport.domain.core.Wagon.dto;
using transport.domain.interfaces;
using transport.infrastructure.data.WagonRepository.Mappers;
using transport.infrastructure.data.WagonRepository.Models;

namespace transport.infrastructure.data.WagonRepository;

public class WagonRepository : IWagonRepository<FuelType, AxisVariant, WagonEntity>
{
    private readonly WagonDbContext _dbContext = new();

    public async Task AddWagonAsync(domain.core.Wagon.Models model)
    {
        await _dbContext.AddAsync(WagonMapper.ToModel(model));
        await _dbContext.SaveChangesAsync();
    }

    public async Task<WagonEntity?> GetWagonByModel(domain.core.Wagon.Models model)
    {
        var result = await _dbContext.Wagons
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.Model == model);

        return result;
    }

    public async Task<Wagon<FuelType, AxisVariant>?> Spawn(domain.core.Wagon.Models model, Player? player = null)
    {
        var wagon = await _dbContext.Wagons
            .AsNoTracking()
            .Include(wagonEntity => wagonEntity.CompatibleAxis)
            .Include(wagonEntity => wagonEntity.CompatibleEngines)
            .Include(wagonEntity => wagonEntity.CompatibleBatteries)
            .Include(wagonEntity => wagonEntity.CompatiblePetrol)
            .FirstOrDefaultAsync(c => c.Model == model);

        if (wagon == null) return null;
        
        var wagonParams = new WagonParams(model, null);
        var truckParams = new TruckParams(100.0f, 100.0f);
        var overlandParams = new OverlandParams<AxisVariant, domain.core.Wagon.Models>([], AxisMapper.ToDomain(wagon.CompatibleAxis[0]));
        var mechanicalParams = new MechanicalParams<FuelType, domain.core.Wagon.Models>(
            [], EngineMapper.ToDomain(wagon.CompatibleEngines[0]), 
            [], PetrolMapper.ToDomain(wagon.CompatiblePetrol[0]), 
            [], BatteryMapper.ToDomain(wagon.CompatibleBatteries[0]));
        
        var controlledParams = new ControlledParams();
        
        var vehicle = Alt.CreateVehicle((uint)model, new Position(player.Position.X, player.Position.Y, player.Position.Z), new Rotation(player.Rotation.Roll, player.Rotation.Pitch, player.Rotation.Yaw));
        var transportParams = new TransportParams(vehicle, player);
        
        return new Wagon<FuelType, AxisVariant>(wagonParams, truckParams, overlandParams, mechanicalParams, controlledParams, transportParams);
    }

    public async Task<Axis<AxisVariant, domain.core.Wagon.Models>?> GetAxisByNameAsync(string name)
    {
        var result = await _dbContext.WagonAxis
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.Name == name);

        return result == null ? null : AxisMapper.ToDomain(result);
    }
    
    public async Task AddAxisAsync(Axis<AxisVariant, domain.core.Wagon.Models> axis, List<WagonEntity>? compatibleWagons = null)
    {
        await _dbContext.AddAsync(AxisMapper.ToModel(axis, compatibleWagons));
        await _dbContext.SaveChangesAsync();
    }
    
    public async Task<Battery<domain.core.Wagon.Models>?> GetBatteryByNameAsync(string name)
    {
        var result = await _dbContext.WagonBatteries
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.Name == name);

        return result == null ? null : BatteryMapper.ToDomain(result);
    }
    
    public async Task AddBatteryAsync(Battery<domain.core.Wagon.Models> battery, List<WagonEntity>? compatibleWagons = null)
    {
        await _dbContext.AddAsync(BatteryMapper.ToModel(battery, compatibleWagons));
        await _dbContext.SaveChangesAsync();
    }
    
    public async Task<Engine<FuelType, domain.core.Wagon.Models>?> GetEngineByNameAsync(string name)
    {
        var result = await _dbContext.WagonEngines
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.Name == name);
        
        return result == null ? null : EngineMapper.ToDomain(result);
    }
    
    public async Task AddEngineAsync(Engine<FuelType, domain.core.Wagon.Models> engine, List<WagonEntity>? compatibleWagons = null)
    {
        await _dbContext.AddAsync(EngineMapper.ToModel(engine, compatibleWagons));
        await _dbContext.SaveChangesAsync();
    }
    
    public async Task<Petrol<FuelType, domain.core.Wagon.Models>?> GetPetrolByNameAsync(string name)
    {
        var result = await _dbContext.WagonPetrol
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.Name == name);
        
        return result == null ? null : PetrolMapper.ToDomain(result);
    }
    
    public async Task AddPetrolAsync(Petrol<FuelType, domain.core.Wagon.Models> petrol, List<WagonEntity>? compatibleWagons = null)
    {
        await _dbContext.AddAsync(PetrolMapper.ToModel(petrol, compatibleWagons));
        await _dbContext.SaveChangesAsync();
    }
}