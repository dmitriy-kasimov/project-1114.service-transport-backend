namespace transport.domain.core.Mechanical.components.Battery.dto;

public abstract class BatteryParams(float maxCharge, float currentCharge = 0.0f)
{
    // max battery charge in A*h
    private float _maxCharge = maxCharge;
    
    // current battery charge in A*h
    private float _currentCharge = currentCharge;
}