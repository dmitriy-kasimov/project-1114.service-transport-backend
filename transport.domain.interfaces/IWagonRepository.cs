using transport.domain.core.Wagon;

namespace transport.domain.interfaces;

public interface IWagonRepository<T, TA>
{
    /* параметры: модель, координаты, поворот */
    public Wagon<T,TA> Create(Models model);
}