namespace transport.domain.core.Mechanical.modules.Petrol.dto;

public class PetrolParams<T>(ushort id, string model, string name,  T? fuelType, float maxFuel, float amountFuel = 0.0f) : IEntity
{
    public ushort Id => id;
    public string Model => model;
    public string Name => name;
    
    private T? _fuelType = fuelType;
    private readonly float _maxFuel = maxFuel;
    private float _amountFuel = amountFuel;
}