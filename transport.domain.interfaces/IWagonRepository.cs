using AltV.Net.Elements.Entities;
using transport.domain.core.Wagon;

namespace transport.domain.interfaces;

public interface IWagonRepository<T, TA>
{
    /* параметры: модель, координаты, поворот */
    public Task<Wagon<T,TA>> Create(Player player,  Models model);
}