using AltV.Net;
using AltV.Net.Data;
using AltV.Net.Elements.Entities;
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

namespace transport.infrastructure.data.WagonRepository;

public class WagonRepository : IWagonRepository<FuelType, AxisVariant>
{
    public Wagon<FuelType, AxisVariant> Create(Player player, domain.core.Wagon.Models model, Engine<FuelType> engine, Petrol<FuelType> petrol, Battery battery, Axis<AxisVariant> axis)
    {
        var wagonParams = new WagonParams(null);
        var truckParams = new TruckParams(100.0f, 100.0f);
        
        var overlandParams = new OverlandParams<AxisVariant>(axis);
        
        var mechanicalParams = new MechanicalParams<FuelType>(engine, petrol, battery);
        
        var controlledParams = new ControlledParams();

        var vehicle = Alt.CreateVehicle((uint)model, new Position(player.Position.X, player.Position.Y, player.Position.Z), new Rotation(player.Rotation.Roll, player.Rotation.Pitch, player.Rotation.Yaw));
        var transportParams = new TransportParams(vehicle, player);
        return new Wagon<FuelType, AxisVariant>(wagonParams, truckParams, overlandParams, mechanicalParams, controlledParams, transportParams);
    }
    public Wagon<FuelType, AxisVariant> Create(Player player, domain.core.Wagon.Models model)
    {
        var wagonParams = new WagonParams(null);
        var truckParams = new TruckParams(100.0f, 100.0f);

        var axisMetaData = new EntityMetaData("0", "axis-1", "The First Axis");
        var axisSpecification = new AxisSpecification<AxisVariant>(AxisVariant.Three);
        var axis = new Axis<AxisVariant>(axisMetaData, axisSpecification, [100.0m,100.0m,100.0m,100.0m,100.0m,100.0m,100.0m,100.0m,100.0m,100.0m]);
        var overlandParams = new OverlandParams<AxisVariant>(axis);

        var engineMetaData = new EntityMetaData("0", "engine-1", "The first Engine");
        var engineSpecification = new EngineSpecification<FuelType>(100.0m, [FuelType.Diesel, FuelType.Octane92]);
        var engine = new Engine<FuelType>(engineMetaData, engineSpecification);
        

        var petrolMetaData = new EntityMetaData("0", "petrol-1", "The first Petrol");
        var petrolSpecification = new PetrolSpecification(150.0m);
        var petrol = new Petrol<FuelType>(petrolMetaData, petrolSpecification, FuelType.Diesel, 100.0f);
        
        var batteryMetaData = new EntityMetaData("0", "battery-1", "The first Battery");
        var batterySpecification = new BatterySpecification(60.0m);
        var battery = new Battery(batteryMetaData, batterySpecification, 50.0f);
        
        var mechanicalParams = new MechanicalParams<FuelType>(engine, petrol, battery);


        var controlledParams = new ControlledParams();

        var vehicle = Alt.CreateVehicle((uint)model, new Position(player.Position.X, player.Position.Y, player.Position.Z), new Rotation(player.Rotation.Roll, player.Rotation.Pitch, player.Rotation.Yaw));
        var transportParams = new TransportParams(vehicle, player);
        return new Wagon<FuelType, AxisVariant>(wagonParams, truckParams, overlandParams, mechanicalParams, controlledParams, transportParams);
    }
}