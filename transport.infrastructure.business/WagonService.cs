using AltV.Net.Elements.Entities;
using transport.domain.core;
using transport.domain.core.Mechanical;
using transport.domain.core.Mechanical.modules.Engine;
using transport.domain.core.Overland;
using transport.domain.core.Wagon;
using transport.infrastructure.data.WagonEngineRepository;
using transport.infrastructure.data.WagonRepository;
using transport.services.interfaces;

namespace transport.infrastructure.business;

public class WagonService : IWagonService
{
    private readonly WagonRepository _wagonRepository = new WagonRepository();
    private readonly WagonEngineRepository _wagonEngineRepository =  new WagonEngineRepository();
    
    private readonly Dictionary<IVehicle, Wagon<FuelType, AxisVariant>> _wagons = [];
    

    public async void Create(Player player, Models model)
    {
        // try
        // {
        //     Console.WriteLine("Creating engine...");
        //     var engineMetaData = new EntityMetaData("0", "engine-1", "The first Engine");
        //     var engineSpecification = new EngineSpecification<FuelType>(100.0m, [FuelType.Diesel, FuelType.Octane92]);
        //     Console.WriteLine("Trying to write engine into DB...");
        //     await _wagonEngineRepository.AddAsync(engineMetaData, engineSpecification);
        //     Console.WriteLine("Engine successfully wrote into DB!");
        // }
        // catch (Exception e)
        // {
        //     Console.WriteLine("Failed try to write engine into DB:");
        //     Console.WriteLine(e);
        // }   
        try
        {
            Console.WriteLine("Trying to read engine from DB by model with value \"engine-1\"...");
            var z = await _wagonEngineRepository.GetByModel("engine-1");
            Console.WriteLine("Engine successfully read from DB!");
            Console.WriteLine(z);
        }
        catch (Exception e)
        {
            Console.WriteLine("Failed try to read engine from DB:");
            Console.WriteLine(e);
        }
        
        var newWagon = _wagonRepository.Create(player, Models.Packer);
        _wagons[newWagon.TransportParams.Vehicle] = newWagon;
        
        PrintWagons();
    }

    private void PrintWagons()
    {
        Console.WriteLine("Owners of wagons:");
        foreach (var wagon in _wagons)
        {
            Console.WriteLine(wagon.Value.TransportParams.Owner?.Name);
        }
    }
}