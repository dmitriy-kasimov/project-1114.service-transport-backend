namespace transport.domain.core.Mechanical.modules.Engine.dto;

public class EngineParams<T>(string id, string name, float bsfc, T[] acceptedTypesFuel) : IEntity
{
    public string Id => id;
    public string Name => name;
    
    // Brake-Specific Fuel Consumption (BSFC): How much fuel is used per unit of power (g/kWh).
    private float _bsfc = bsfc;

    private T[] _acceptedTypesFuel = acceptedTypesFuel;
}