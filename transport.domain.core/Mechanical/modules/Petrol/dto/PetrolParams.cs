namespace transport.domain.core.Mechanical.modules.Petrol.dto;

public class PetrolParams<T>(string id, string name, T? fuelType, float maxFuel, float amountFuel = 0.0f) : IEntity
{
    public string Id => id;
    public string Name => name;
    
    private T? _fuelType = fuelType;
    private readonly float _maxFuel = maxFuel;
    private float _amountFuel = amountFuel;
}