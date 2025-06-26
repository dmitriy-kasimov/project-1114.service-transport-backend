using transport.domain.core.Mechanical.modules.Petrol.dto;

namespace transport.domain.core.Mechanical.modules.Petrol;

public class Petrol<T>(PetrolParams<T> parameters)
{
    public PetrolParams<T> Params => parameters;
}