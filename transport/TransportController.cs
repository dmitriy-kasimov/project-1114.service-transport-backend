using AltV.Net;
using AltV.Net.Elements.Entities;
using AltV.Net.Resources.Chat.Api;
using transport.domain.core.Wagon;
using transport.infrastructure.business;
using transport.infrastructure.data.WagonRepository;

namespace Transport;

public class TransportController : IScript
{
    private readonly WagonService _wagonsService = new();
    
    [Command("truck")]
    public void SpawnTruck(Player player)
    {
        _wagonsService.Create(player, Models.Packer);
    }
}