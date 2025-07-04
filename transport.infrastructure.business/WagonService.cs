using AltV.Net.Elements.Entities;
using transport.domain.core.Mechanical;
using transport.domain.core.Overland;
using transport.domain.core.Wagon;
using transport.infrastructure.data.WagonRepository;
using transport.infrastructure.data.WagonRepository.Models;
using transport.services.interfaces;

namespace transport.infrastructure.business;

public class WagonService : IWagonService
{
    private readonly WagonRepository _wagonRepository = new WagonRepository();
    
    private readonly Dictionary<IVehicle, Wagon<FuelType, AxisVariant, WagonEntity>> _wagons = [];
    

    public async void Create(Player player, Models model)
    {
        // try
        // {
        //     Console.WriteLine($"Creating wagon: {Models.Hauler} ...");
        //     await _wagonRepository.AddWagonAsync(Models.Hauler);
        //     Console.WriteLine("done");
        // }
        // catch (Exception e)
        // {
        //     Console.WriteLine("gandone");
        //     Console.WriteLine(e);
        // }
        try
        {
            var newWagon = await _wagonRepository.Create(player, Models.Hauler);
            if (newWagon == null) throw new Exception();
            
            _wagons[newWagon.TransportParams.Vehicle] = newWagon;
            PrintWagons();
        }
        catch (Exception e)
        {
            Console.WriteLine("Failed try spawn a truck");
            Console.WriteLine(e);
        }
    }

    private void PrintWagons()
    {
        Console.WriteLine("Owners of wagons:");
        foreach (var wagon in _wagons)
        {
            Console.WriteLine("Wagon of " + wagon.Value.TransportParams.Owner?.Name + "'");
            Console.WriteLine("Engine name " + wagon.Value.MechanicalParams.Engine.MetaData.Name);
            Console.WriteLine("Engine bsfc " + wagon.Value.MechanicalParams.Engine.Specification.Bsfc);
            Console.WriteLine("Petrol name " + wagon.Value.MechanicalParams.Petrol.MetaData.Name);
            Console.WriteLine("Petrol capacity " + wagon.Value.MechanicalParams.Petrol.Specification.Capacity);
            Console.WriteLine("Battery name " + wagon.Value.MechanicalParams.Battery.MetaData.Name);
            Console.WriteLine("Battery Capacity " + wagon.Value.MechanicalParams.Battery.Specification.MaxCharge);
            Console.WriteLine("Axis name " + wagon.Value.OverlandParams.Axis.MetaData.Name);
            Console.WriteLine("Axis variant " + wagon.Value.OverlandParams.Axis.Specification.Axis);
        }
    }
}