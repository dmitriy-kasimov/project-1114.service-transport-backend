using AltV.Net;
using AltV.Net.Elements.Entities;
using AltV.Net.Enums;
using AltV.Net.Resources.Chat.Api;

namespace Transport;

public class Test : IScript
{

    [ScriptEvent(ScriptEventType.PlayerEnterVehicle)]
    public void OnPlayerEnterVehicle(Transport vehicle, IPlayer player, byte seat)
    {
        player.Emit("s:c:vehicleInit");
    }

    [Command("hauler")]
    public void SpawnHauler(Player player)
    {
        Console.WriteLine("HAULER was spawned!");
        var position = player.Position;
        var rotation = player.Rotation;
        var vehicle = Alt.CreateVehicle(VehicleModel.Hauler, position, rotation);
        
        vehicle.ManualEngineControl = true;
        vehicle.EngineOn = false;
    }

    [Command("control")]
    public void OnControl(Player player)
    {
        if (!player.IsInVehicle) return;
        player.Emit("s:c:controlShow");
    }
}