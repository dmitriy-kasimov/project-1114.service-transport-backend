namespace transport.domain.core.Mechanical.modules.Petrol.dto;

public abstract class PetrolParams<T>(T fuelType, float maxFuel, float amountFuel = 0.0f)
{
    private T _fuelType = fuelType;
    private readonly float _maxFuel = maxFuel;
    private float _amountFuel = amountFuel;
}