using AltV.Net;
using AltV.Net.Elements.Entities;
using AltV.Net.Resources.Chat.Api;
using transport.domain.core.Truck;
using transport.infrastructure.business;

namespace Transport;

public class Test : IScript
{
    [Command("hauler")]
    public void SpawnHauler(Player player)
    {
        Console.WriteLine("hauler-command was called!!!");
        var position = player.Position;
        var rotation = player.Rotation;
        var vehicle = Alt.CreateVehicle(TrucksDictionary.GetAltModelByTruckModel[TruckModels.Hauler], position, rotation);
        player.SetIntoVehicle(vehicle, 0);
    }
}