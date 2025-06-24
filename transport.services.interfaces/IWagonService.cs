using AltV.Net.Elements.Entities;
using transport.domain.core.Wagon;

namespace transport.services.interfaces;

public interface IWagonService
{
    public void Create(Player player, Models model);
}