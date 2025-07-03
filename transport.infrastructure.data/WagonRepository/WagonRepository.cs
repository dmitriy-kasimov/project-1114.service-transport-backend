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

public class WagonRepository : IWagonRepository<FuelType, AxisVariant>
{
    private readonly WagonDbContext _dbContext = new();

    public async Task<bool> AddWagonAsync(domain.core.Wagon.Models model)
    {
        var z = new WagonEntity
        {
            Model = domain.core.Wagon.Models.Hauler,
            CompatibleWagonAxis = [
                new AxisEntity()
                {
                    Model = "axis-2",
                    Name = "The Second Axis",
                    Axis = AxisVariant.Three,
                    CompatibleTransports = [domain.core.Wagon.Models.Packer, domain.core.Wagon.Models.Hauler],
                }],
            CompatibleWagonBatteries = [
                new BatteryEntity()
                {
                    Model = "battery-2",
                    Name = "The Second Battery",
                    MaxCharge = 120.0m,
                    CompatibleTransports = [domain.core.Wagon.Models.Packer, domain.core.Wagon.Models.Hauler],
                }
            ],
            CompatibleWagonEngines = [
                new EngineEntity()
                {
                    Model = "engine-2",
                    Name = "The Second Engine",
                    CompatibleTransports = [domain.core.Wagon.Models.Hauler],
                    AcceptedTypesFuel = [FuelType.Diesel],
                    Bsfc = 180.0m
                }
            ],
            CompatibleWagonPetrol = [
                new PetrolEntity()
                {
                    Model = "petrol-2",
                    Name = "The Second Petrol",
                    CompatibleTransports = [domain.core.Wagon.Models.Hauler],
                    Capacity = 180.0m,
                }
            ]
        };
        await _dbContext.AddAsync(z);
        await _dbContext.SaveChangesAsync();

        return true;
    }

    public async Task<Wagon<FuelType, AxisVariant>?>  Create(Player player, domain.core.Wagon.Models model)
    {
        var wagon = await _dbContext.Wagons
            .AsNoTracking()
            .Include(wagonEntity => wagonEntity.CompatibleWagonAxis)
            .Include(wagonEntity => wagonEntity.CompatibleWagonEngines)
            .Include(wagonEntity => wagonEntity.CompatibleWagonBatteries)
            .Include(wagonEntity => wagonEntity.CompatibleWagonPetrol)
            .FirstOrDefaultAsync(c => c.Model == model);

        if (wagon == null) return null;

        var defaultAxis = wagon.CompatibleWagonAxis[0];
        var defaultEngine = wagon.CompatibleWagonEngines[0];
        var defaultBattery = wagon.CompatibleWagonBatteries[0];
        var defaultPetrol = wagon.CompatibleWagonPetrol[0];
        
        var wagonParams = new WagonParams(null);
        var truckParams = new TruckParams(100.0f, 100.0f);
        
        var overlandParams = new OverlandParams<AxisVariant, domain.core.Wagon.Models>([], defaultAxis.Model, AxisMapper.ToDomain(defaultAxis));
        
        var mechanicalParams = new MechanicalParams<FuelType, domain.core.Wagon.Models>(
            [], defaultEngine.Model, EngineMapper.ToDomain(defaultEngine), 
            [],  defaultPetrol.Model, PetrolMapper.ToDomain(defaultPetrol), 
            [],  defaultBattery.Model, BatteryMapper.ToDomain(defaultBattery));
        
        var controlledParams = new ControlledParams();

        var vehicle = Alt.CreateVehicle((uint)model, new Position(player.Position.X, player.Position.Y, player.Position.Z), new Rotation(player.Rotation.Roll, player.Rotation.Pitch, player.Rotation.Yaw));
        var transportParams = new TransportParams(vehicle, player);
        return new Wagon<FuelType, AxisVariant>(wagonParams, truckParams, overlandParams, mechanicalParams, controlledParams, transportParams);
    }

    public async Task<Axis<AxisVariant, domain.core.Wagon.Models>?> GetAxisByModelAsync(string model)
    {
        var result = await _dbContext.WagonAxis
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.Model == model);

        return result == null ? null : AxisMapper.ToDomain(result);
    }
    
    public async Task AddAxisAsync(Axis<AxisVariant, domain.core.Wagon.Models> axis)
    {
        await _dbContext.AddAsync(AxisMapper.ToModel(axis));
        await _dbContext.SaveChangesAsync();
    }
    
    public async Task<Battery<domain.core.Wagon.Models>?> GetBatteryByModelAsync(string model)
    {
        var result = await _dbContext.WagonBatteries
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.Model == model);

        return result == null ? null : BatteryMapper.ToDomain(result);
    }
    
    public async Task AddBatteryAsync(Battery<domain.core.Wagon.Models> battery)
    {
        await _dbContext.AddAsync(BatteryMapper.ToModel(battery));
        await _dbContext.SaveChangesAsync();
    }
    
    public async Task<Engine<FuelType, domain.core.Wagon.Models>?> GetEngineByModelAsync(string model)
    {
        var result = await _dbContext.WagonEngines
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.Model == model);
        
        return result == null ? null : EngineMapper.ToDomain(result);
    }
    
    public async Task AddEngineAsync(Engine<FuelType, domain.core.Wagon.Models> engine)
    {
        await _dbContext.AddAsync(EngineMapper.ToModel(engine));
        await _dbContext.SaveChangesAsync();
    }
    
    public async Task<Petrol<FuelType, domain.core.Wagon.Models>?> GetPetrolByModelAsync(string model)
    {
        var result = await _dbContext.WagonPetrol
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.Model == model);
        
        return result == null ? null : PetrolMapper.ToDomain(result);
    }
    
    public async Task AddPetrolAsync(Petrol<FuelType, domain.core.Wagon.Models> petrol)
    {
        await _dbContext.AddAsync(PetrolMapper.ToModel(petrol));
        await _dbContext.SaveChangesAsync();
    }
}