using AltV.Net.Elements.Entities;
using transport.domain.core.Mechanical;
using transport.domain.core.Overland;
using transport.domain.core.Wagon;
using transport.infrastructure.data.WagonRepository;
using transport.services.interfaces;

namespace transport.infrastructure.business;

public class WagonService : IWagonService
{
    private readonly WagonRepository _wagonRepository = new WagonRepository();
    
    private readonly Dictionary<IVehicle, Wagon<FuelType, AxisVariant>> _wagons = [];
    

    public async void Create(Player player, Models model)
    {
        try
        {
            Console.WriteLine("Trying to read modules...");
            var engine = await _wagonRepository.GetEngineByModelAsync("engine-1");
            var petrol = await _wagonRepository.GetPetrolByModelAsync("petrol-1");
            var battery = await _wagonRepository.GetBatteryByModelAsync("battery-1");
            var axis = await _wagonRepository.GetAxisByModelAsync("axis-1");
            Console.WriteLine("Modules successfully has been read from DB!");

            var newWagon = _wagonRepository.Create(player, Models.Packer, engine!, petrol!, battery!, axis!);
            _wagons[newWagon.TransportParams.Vehicle] = newWagon;
        
            PrintWagons();
        }
        catch (Exception e)
        {
            Console.WriteLine("Failed try to read engine from DB:");
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