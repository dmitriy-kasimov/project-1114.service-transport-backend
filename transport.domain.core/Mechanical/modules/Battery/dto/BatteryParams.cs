namespace transport.domain.core.Mechanical.modules.Battery.dto;

public class BatteryParams(string id, string name, float maxCharge, float currentCharge = 0.0f) : IEntity
{
    public string Id => id;
    public string Name => name;
    
    
    // max battery charge in A*h
    private float _maxCharge = maxCharge;
    
    // current battery charge in A*h
    private float _currentCharge = currentCharge;
}