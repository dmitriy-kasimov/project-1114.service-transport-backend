using transport.domain.core.Mechanical.modules.Petrol.dto;

namespace transport.domain.core.Mechanical.modules.Petrol;

public class Petrol<T>(PetrolParams<T> petrolParams)
{
    private PetrolParams<T> _petrolParams = petrolParams;
}