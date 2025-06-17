using AltV.Net;
using AltV.Net.Elements.Entities;
using AltV.Net.Enums;

namespace Transport;

public class Transport : Vehicle
{
    public Transport(ICore core, IntPtr nativePointer, uint id) : base(core, nativePointer, id)
    {
        Init();
    }

    private void Init()
    {
        if (Model == (uint)VehicleModel.Hauler)
        {
            Console.WriteLine("HAULER!!!");
        }
        else
        {
            Console.WriteLine("NOT HAULER :(");
        }
    }
}

public class TransportFactory : IEntityFactory<Vehicle>
{
    public Vehicle Create(ICore core, IntPtr playerPointer, uint id)
    {
        return new Transport(core, playerPointer, id);
    }
}