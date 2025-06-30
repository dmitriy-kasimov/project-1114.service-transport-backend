using AltV.Net.Elements.Entities;
using transport.domain.core.Mechanical.modules.Battery;
using transport.domain.core.Mechanical.modules.Engine;
using transport.domain.core.Mechanical.modules.Petrol;
using transport.domain.core.Overland.modules.Axis;
using transport.domain.core.Wagon;

namespace transport.domain.interfaces;

public interface IWagonRepository<T, TA>
{
    /* параметры: модель, координаты, поворот */
    public Wagon<T,TA> Create(Player player,  Models model);
    public Wagon<T,TA> Create(Player player,  Models model, Engine<T> engine, Petrol<T> petrol, Battery battery, Axis<TA> axis);
}