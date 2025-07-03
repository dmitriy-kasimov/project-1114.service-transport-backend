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
        // TODO .AsNoTracking() - без него работает кольцевая ссылка wagon -> module -> wagon ...
        var result = await _dbContext.Wagons
            .Include(wagonEntity => wagonEntity.CompatibleWagonAxis)
            .ThenInclude(axisEntity => axisEntity.CompatibleWagons)
            .Include(wagonEntity => wagonEntity.CompatibleWagonEngines)
            .Include(wagonEntity => wagonEntity.CompatibleWagonBatteries)
            .Include(wagonEntity => wagonEntity.CompatibleWagonPetrol)
            .FirstOrDefaultAsync(c => c.Model == model);

        if (result == null) return null;

        var axis = result.CompatibleWagonAxis[0];
        Console.WriteLine("Check the link from module to wagon");
        Console.WriteLine(axis.CompatibleWagons[0].Model);
        var axisMetaData = new ModuleMetaData<domain.core.Wagon.Models>(axis.Model, axis.Name, axis.CompatibleTransports);
        var axisSpecification = new AxisSpecification<AxisVariant>(axis.Axis);
        var m2 = new Axis<AxisVariant, domain.core.Wagon.Models>(axisMetaData, axisSpecification, []);
        
        var engine = result.CompatibleWagonEngines[0];
        var engineMetaData = new ModuleMetaData<domain.core.Wagon.Models>(engine.Model, engine.Name, engine.CompatibleTransports);
        var engineSpecification = new EngineSpecification<FuelType>(engine.Bsfc, engine.AcceptedTypesFuel);
        var m1 = new Engine<FuelType, domain.core.Wagon.Models>(engineMetaData, engineSpecification);
        
        var battery = result.CompatibleWagonBatteries[0];
        var petrolMetaData = new ModuleMetaData<domain.core.Wagon.Models>(battery.Model, battery.Name, battery.CompatibleTransports);
        var petrolSpecification = new BatterySpecification(battery.MaxCharge);
        var m3 = new Battery<domain.core.Wagon.Models>(petrolMetaData, petrolSpecification);
        
        var petrol = result.CompatibleWagonPetrol[0];
        var metaData = new ModuleMetaData<domain.core.Wagon.Models>(petrol.Model, petrol.Name, petrol.CompatibleTransports);
        var specification = new PetrolSpecification(petrol.Capacity);
        var m4 = new Petrol<FuelType, domain.core.Wagon.Models>(metaData, specification, FuelType.Octane92);
        
        var wagonParams = new WagonParams(null);
        var truckParams = new TruckParams(100.0f, 100.0f);
        
        var overlandParams = new OverlandParams<AxisVariant, domain.core.Wagon.Models>([], axis.Model, m2);
        
        var mechanicalParams = new MechanicalParams<FuelType, domain.core.Wagon.Models>(
            [], engine.Model, m1, 
            [],  petrol.Model, m4, 
            [],  battery.Model, m3);
        
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

        if (result == null) return null;
        
        var metaData = new ModuleMetaData<domain.core.Wagon.Models>(result.Model, result.Name, result.CompatibleTransports);
        var specification = new AxisSpecification<AxisVariant>(result.Axis);
        return new Axis<AxisVariant, domain.core.Wagon.Models>(metaData, specification, []);
    }
    
    public async Task AddAxisAsync(ModuleMetaData<domain.core.Wagon.Models> metaData, AxisSpecification<AxisVariant> specification)
    {
        var z = new AxisEntity
        {
            Model = metaData.Model,
            Name = metaData.Name,
            Axis = specification.Axis,
        };
        await _dbContext.AddAsync(z);
        await _dbContext.SaveChangesAsync();
    }
    
    public async Task<Battery<domain.core.Wagon.Models>?> GetBatteryByModelAsync(string model)
    {
        var result = await _dbContext.WagonBatteries
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.Model == model);

        if (result == null) return null;
        
        var metaData = new ModuleMetaData<domain.core.Wagon.Models>(result.Model, result.Name, result.CompatibleTransports);
        var specification = new BatterySpecification(result.MaxCharge);
        return  new Battery<domain.core.Wagon.Models>(metaData, specification);
    }
    
    public async Task AddBatteryAsync(ModuleMetaData<domain.core.Wagon.Models> metaData, BatterySpecification specification)
    {
        var z = new BatteryEntity
        {
            Model = metaData.Model,
            Name = metaData.Name,
            MaxCharge = specification.MaxCharge,
        };
        await _dbContext.AddAsync(z);
        await _dbContext.SaveChangesAsync();
    }
    
    public async Task<Engine<FuelType, domain.core.Wagon.Models>?> GetEngineByModelAsync(string model)
    {
        var result = await _dbContext.WagonEngines
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.Model == model);
        
        if (result == null) return null;
        
        var metaData = new ModuleMetaData<domain.core.Wagon.Models>(result.Model, result.Name, result.CompatibleTransports);
        var specification = new EngineSpecification<FuelType>(result.Bsfc, result.AcceptedTypesFuel);
        return  new Engine<FuelType, domain.core.Wagon.Models>(metaData, specification);
    }
    
    public async Task AddEngineAsync(ModuleMetaData<domain.core.Wagon.Models> metaData, EngineSpecification<FuelType> specification)
    {
        var z = new EngineEntity
        {
            Model = metaData.Model,
            Name = metaData.Name,
            Bsfc = specification.Bsfc,
            AcceptedTypesFuel = specification.AcceptedTypesFuel,
        };
        await _dbContext.AddAsync(z);
        await _dbContext.SaveChangesAsync();
    }
    
    public async Task<Petrol<FuelType, domain.core.Wagon.Models>?> GetPetrolByModelAsync(string model)
    {
        var result = await _dbContext.WagonPetrol
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.Model == model);
        
        if (result == null) return null;
        
        var metaData = new ModuleMetaData<domain.core.Wagon.Models>(result.Model, result.Name, result.CompatibleTransports);
        var specification = new PetrolSpecification(result.Capacity);
        return new Petrol<FuelType, domain.core.Wagon.Models>(metaData, specification, FuelType.Octane92);
    }
    
    public async Task AddPetrolAsync(ModuleMetaData<domain.core.Wagon.Models> metaData, PetrolSpecification specification)
    {
        var z = new PetrolEntity
        {
            Model = metaData.Model,
            Name = metaData.Name,
            Capacity = specification.Capacity
        };
        await _dbContext.AddAsync(z);
        await _dbContext.SaveChangesAsync();
    }
}