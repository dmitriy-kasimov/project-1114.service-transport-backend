namespace transport.domain.core.Mechanical.modules.Engine.dto;

public class EngineParams<T>(ushort id, string model, string name, float bsfc, T[] acceptedTypesFuel) : IEntity
{
    public ushort Id => id;
    public string Model => model;
    public string Name => name;
    
    // Brake-Specific Fuel Consumption (BSFC): How much fuel is used per unit of power (g/kWh).
    private float _bsfc = bsfc;

    private T[] _acceptedTypesFuel = acceptedTypesFuel;
}