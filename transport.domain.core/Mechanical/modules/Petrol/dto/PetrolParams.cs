namespace transport.domain.core.Mechanical.modules.Petrol.dto;

public abstract class PetrolParams(float maxFuel, float amountFuel = 0.0f)
{
    private readonly float _maxFuel = maxFuel;
    private float _amountFuel = amountFuel;
}