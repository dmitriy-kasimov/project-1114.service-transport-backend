// using AltV.Net;
// using AltV.Net.Elements.Entities;
// using AltV.Net.Enums;
// using AltV.Net.Resources.Chat.Api;
// using transport.domain.core.Truck;
// using transport.infrastructure.business;
//
// namespace Transport;
//
// public class TransportController : Resource, IScript
// {
//     private TruckService? _truckService;
//     public override void OnStart()
//     {
//         _truckService = new TruckService();
//     }
//
//     public override void OnStop()
//     {
//             
//     }
//
//     [ClientEvent("c:s:CreateTruck")]
//     public void CreateTruckHandler(Player player, string truckId)
//     {
//         var truckIdInt = Int32.Parse(truckId);
//         var position = player.Position;
//         var rotation = player.Rotation;
//         var truck = _truckService?.Create((TruckModels)truckIdInt, position, rotation);
//         player.SetIntoVehicle(truck?.Vehicle, 0);
//     }
//     
//     public void CreateTruck(Player player, string truckId)
//     {
//         var truckIdInt = Int32.Parse(truckId);
//         var position = player.Position;
//         var rotation = player.Rotation;
//         var truck = _truckService?.Create((TruckModels)truckIdInt, position, rotation);
//         player.SetIntoVehicle(truck?.Vehicle, 0);
//     }
//     
//     [ClientEvent("c:s:toggleEngine")]
//     public void ToggleEngineHandler(Player player, IVehicle vehicle)
//     {
//         if (player.IsInVehicle)
//         {
//             var passengers = vehicle.Passengers;
//             foreach (var passenger in passengers)
//             {
//                 if (passenger.Player.Equals(player) && passenger.Seat == 0)
//                 {
//                     _truckService?.ToggleEngine(vehicle);
//                 }
//             }
//         }
//     }
//     
//     [ClientEvent("c:s:setLights")]
//     public void SetLightsHandler(Player player, IVehicle vehicle, byte mode)
//     {
//         _truckService?.SetLights(vehicle, mode);
//     }
//     
//     [ClientEvent("c:s:setDoor")]
//     public void SetDoorHandler(Player player, IVehicle vehicle, VehicleDoor door, VehicleDoorState doorState)
//     {
//         _truckService?.SetDoor(vehicle, door, doorState);
//     }
//     
//     [Command("hauler")]
//     public void SpawnHauler(Player player)
//     {
//         CreateTruck(player, "0");
//     }
// }