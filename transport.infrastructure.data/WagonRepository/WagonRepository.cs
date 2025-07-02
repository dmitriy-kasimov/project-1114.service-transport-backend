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
    public Wagon<FuelType, AxisVariant> Create(Player player, domain.core.Wagon.Models model, Engine<FuelType, domain.core.Wagon.Models> engine, Petrol<FuelType, domain.core.Wagon.Models> petrol, Battery<domain.core.Wagon.Models> battery, Axis<AxisVariant, domain.core.Wagon.Models> axis)
    {
        var wagonParams = new WagonParams(null);
        var truckParams = new TruckParams(100.0f, 100.0f);
        
        var overlandParams = new OverlandParams<AxisVariant, domain.core.Wagon.Models>(axis);
        
        var mechanicalParams = new MechanicalParams<FuelType, domain.core.Wagon.Models>(engine, petrol, battery);
        
        var controlledParams = new ControlledParams();

        var vehicle = Alt.CreateVehicle((uint)model, new Position(player.Position.X, player.Position.Y, player.Position.Z), new Rotation(player.Rotation.Roll, player.Rotation.Pitch, player.Rotation.Yaw));
        var transportParams = new TransportParams(vehicle, player);
        return new Wagon<FuelType, AxisVariant>(wagonParams, truckParams, overlandParams, mechanicalParams, controlledParams, transportParams);
    }
    // public Wagon<FuelType, AxisVariant> Create(Player player, domain.core.Wagon.Models model)
    // {
    //     var wagonParams = new WagonParams(null);
    //     var truckParams = new TruckParams(100.0f, 100.0f);
    //
    //     var axisMetaData = new EntityMetaData<domain.core.Wagon.Models>("axis-1", "The First Axis", [domain.core.Wagon.Models.Packer]);
    //     var axisSpecification = new AxisSpecification<AxisVariant>(AxisVariant.Three);
    //     var axis = new Axis<AxisVariant>(axisMetaData, axisSpecification, [100.0m,100.0m,100.0m,100.0m,100.0m,100.0m,100.0m,100.0m,100.0m,100.0m]);
    //     var overlandParams = new OverlandParams<AxisVariant>(axis);
    //
    //     var engineMetaData = new EntityMetaData<domain.core.Wagon.Models>("engine-1", "The first Engine");
    //     var engineSpecification = new EngineSpecification<FuelType>(100.0m, [FuelType.Diesel, FuelType.Octane92]);
    //     var engine = new Engine<FuelType>(engineMetaData, engineSpecification);
    //     
    //
    //     var petrolMetaData = new EntityMetaData<domain.core.Wagon.Models>("petrol-1", "The first Petrol");
    //     var petrolSpecification = new PetrolSpecification(150.0m);
    //     var petrol = new Petrol<FuelType>(petrolMetaData, petrolSpecification, FuelType.Diesel, 100.0f);
    //     
    //     var batteryMetaData = new EntityMetaData<domain.core.Wagon.Models>("battery-1", "The first Battery");
    //     var batterySpecification = new BatterySpecification(60.0m);
    //     var battery = new Battery(batteryMetaData, batterySpecification, 50.0f);
    //     
    //     var mechanicalParams = new MechanicalParams<FuelType>(engine, petrol, battery);
    //
    //
    //     var controlledParams = new ControlledParams();
    //
    //     var vehicle = Alt.CreateVehicle((uint)model, new Position(player.Position.X, player.Position.Y, player.Position.Z), new Rotation(player.Rotation.Roll, player.Rotation.Pitch, player.Rotation.Yaw));
    //     var transportParams = new TransportParams(vehicle, player);
    //     return new Wagon<FuelType, AxisVariant>(wagonParams, truckParams, overlandParams, mechanicalParams, controlledParams, transportParams);
    // }
    
    public async Task<Axis<AxisVariant, domain.core.Wagon.Models>?> GetAxisByModelAsync(string model)
    {
        var result = await _dbContext.WagonAxis
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.Model == model);


        if (result == null) return null;
        
        var metaData = new EntityMetaData<domain.core.Wagon.Models>(result.Model, result.Name, []);
        var specification = new AxisSpecification<AxisVariant>(result.Axis);
        return new Axis<AxisVariant, domain.core.Wagon.Models>(metaData, specification, []);
    }
    
    public async Task AddAxisAsync(EntityMetaData<domain.core.Wagon.Models> entityMetaData, AxisSpecification<AxisVariant> specification)
    {
        var z = new AxisEntity
        {
            Model = entityMetaData.Model,
            Name = entityMetaData.Name,
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
        
        var metaData = new EntityMetaData<domain.core.Wagon.Models>(result.Model, result.Name, []);
        var specification = new BatterySpecification(result.MaxCharge);
        return  new Battery<domain.core.Wagon.Models>(metaData, specification);
    }
    
    public async Task AddBatteryAsync(EntityMetaData<domain.core.Wagon.Models> entityMetaData, BatterySpecification specification)
    {
        var z = new BatteryEntity
        {
            Model = entityMetaData.Model,
            Name = entityMetaData.Name,
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
        
        var metaData = new EntityMetaData<domain.core.Wagon.Models>(result.Model, result.Name, []);
        var specification = new EngineSpecification<FuelType>(result.Bsfc, result.AcceptedTypesFuel);
        return  new Engine<FuelType, domain.core.Wagon.Models>(metaData, specification);
    }
    
    public async Task AddEngineAsync(EntityMetaData<domain.core.Wagon.Models> entityMetaData, EngineSpecification<FuelType> specification)
    {
        var z = new EngineEntity
        {
            Model = entityMetaData.Model,
            Name = entityMetaData.Name,
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
        
        var metaData = new EntityMetaData<domain.core.Wagon.Models>(result.Model, result.Name, []);
        var specification = new PetrolSpecification(result.Capacity);
        return new Petrol<FuelType, domain.core.Wagon.Models>(metaData, specification, FuelType.Octane92);
    }
    
    public async Task AddPetrolAsync(EntityMetaData<domain.core.Wagon.Models> entityMetaData, PetrolSpecification specification)
    {
        var z = new PetrolEntity
        {
            Model = entityMetaData.Model,
            Name = entityMetaData.Name,
            Capacity = specification.Capacity
        };
        await _dbContext.AddAsync(z);
        await _dbContext.SaveChangesAsync();
    }
}