using AltV.Net;
using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using transport.domain.core.Controlled.dto;
using transport.domain.core.Mechanical;
using transport.domain.core.Mechanical.dto;
using transport.domain.core.Mechanical.modules.Battery;
using transport.domain.core.Mechanical.modules.Battery.dto;
using transport.domain.core.Mechanical.modules.Engine;
using transport.domain.core.Mechanical.modules.Engine.dto;
using transport.domain.core.Mechanical.modules.Petrol;
using transport.domain.core.Mechanical.modules.Petrol.dto;
using transport.domain.core.Overland;
using transport.domain.core.Overland.dto;
using transport.domain.core.Overland.modules.Axis;
using transport.domain.core.Overland.modules.Axis.dto;
using transport.domain.core.Transport.dto;
using transport.domain.core.Truck.dto;
using transport.domain.core.Wagon;
using transport.domain.core.Wagon.dto;
using transport.domain.interfaces;

namespace transport.infrastructure.data.WagonRepository;

public class WagonRepository : IWagonRepository<FuelType, AxisVariant>
{
    public Wagon<FuelType, AxisVariant> Create(Player player, Models model)
    {
        var wagonParams = new WagonParams(null);
        var truckParams = new TruckParams(100.0f, 100.0f);
        
        var axisParams = new AxisParams<AxisVariant>(AxisVariant.Three, [100.0f,100.0f,100.0f,100.0f,100.0f,100.0f,100.0f,100.0f,100.0f,100.0f]);
        var axis = new Axis<AxisVariant>(axisParams);
        var overlandParams = new OverlandParams<AxisVariant>("axis-1", "The first axis for Packer!", axis);

        
        var engineParams = new EngineParams<FuelType>("engine-1", "The first engine for Packer!", 100.0f, [FuelType.Diesel, FuelType.Octane92]);
        var engine = new Engine<FuelType>(engineParams);

        var petrolParams = new PetrolParams<FuelType>("petrol-1", "The first petrol for Packer!", FuelType.Diesel, 300.0f, 100.0f);
        var petrol = new Petrol<FuelType>(petrolParams);
        
        var batteryParams = new BatteryParams("battery-1", "The first battery for Packer!", 300.0f, 100.0f);
        var battery = new Battery(batteryParams);
        
        var mechanicalParams = new MechanicalParams<FuelType>(engine, petrol, battery);


        var controlledParams = new ControlledParams();

        var vehicle = Alt.CreateVehicle((uint)model, new Position(player.Position.X, player.Position.Y, player.Position.Z+1), new Rotation(player.Rotation.Roll, player.Rotation.Pitch, player.Rotation.Yaw));
        var transportParams = new TransportParams(vehicle, player);
        return new Wagon<FuelType, AxisVariant>(wagonParams, truckParams, overlandParams, mechanicalParams, controlledParams, transportParams);
    }
}