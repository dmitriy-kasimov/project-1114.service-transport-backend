using AltV.Net.Elements.Entities;
using transport.domain.core.Wagon;
using transport.domain.interfaces;
using transport.infrastructure.data.WagonRepository;
using transport.services.interfaces;

namespace transport.infrastructure.business;

public class WagonService(IWagonRepository<FuelType, AxisVariant> wagonRepository) : IWagonService
{
    private readonly Dictionary<IVehicle, Wagon<FuelType, AxisVariant>> _wagons = [];

    public void Create(Player player, Models model)
    {
        var newWagon = wagonRepository.Create(player, Models.Packer);
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