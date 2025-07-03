namespace transport.domain.core.Mechanical.modules.Battery;

public class Battery<T>(ModuleMetaData<T> moduleMetaData,  BatterySpecification batterySpecification, float currentCharge = 0.0f) : IModule<T>, IBattery
{
    public ModuleMetaData<T> MetaData => moduleMetaData;
    public BatterySpecification Specification => batterySpecification;
    
    // current battery charge in A*h
    private float _currentCharge = currentCharge;
}