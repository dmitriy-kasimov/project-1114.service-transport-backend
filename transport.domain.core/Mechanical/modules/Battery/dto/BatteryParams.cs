namespace transport.domain.core.Mechanical.modules.Battery.dto;

public class BatteryParams(ushort id, string model, string name,  float maxCharge, float currentCharge = 0.0f) : IEntity
{
    public ushort Id => id;
    public string Model => model;
    public string Name => name;
    
    // max battery charge in A*h
    private float _maxCharge = maxCharge;
    
    // current battery charge in A*h
    private float _currentCharge = currentCharge;
}