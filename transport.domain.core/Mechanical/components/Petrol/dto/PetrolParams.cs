namespace transport.domain.core.Mechanical.components.Petrol.dto;

public abstract class PetrolParams(float maxFuel, FuelType fuelType, float amountFuel = 0.0f)
{
    private readonly float _maxFuel = maxFuel;
    private FuelType _fuelType = fuelType;
    private float _amountFuel = amountFuel;
}