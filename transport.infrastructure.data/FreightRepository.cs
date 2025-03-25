using AltV.Net;
using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using AltV.Net.Enums;
using transport.domain.core;
using transport.domain.core.Freight;
using transport.domain.core.Freight.Axis;
using transport.domain.core.IGround.IChassis;
using transport.domain.core.IGround.IChassis.WheelChassis;
using transport.domain.core.IMechanical.IPlatform;
using transport.domain.interfaces;

namespace transport.infrastructure.data;

public class FreightRepository : IFreightRepository
{
    
    public Freight Create(FreightModels freightModel, Position position, Rotation rotation)
    {
        Axis axis;
        WheelChassis wheelChassis;
        IPlatform platform;
        switch (freightModel)
        {
            case FreightModels.Hauler:
            {
                axis = new Axis("ax_hauler", "Hauler Axis", "Модуль для Hauler", 200);
                wheelChassis = new WheelChassis("ax_hauler", EWheelAxis.Three);
                break;
            }
            default:
            {
                axis = new Axis("ax_hauler_2", "Hauler 2 Axis", "Модуль для Hauler 2", 200);
                wheelChassis = new WheelChassis("ax_hauler", EWheelAxis.Three);
                break;
            }
        }
        
        IVehicle veh = Alt.CreateVehicle(VehicleModel.aleutian, position, rotation);
        return new Freight(axis, null, wheelChassis);
    }
}