namespace transport.domain.core.Mechanical.modules.Battery;

public class Battery<T>(EntityMetaData<T> entityMetaData,  BatterySpecification batterySpecification, float currentCharge = 0.0f) : IEntity<T>, IBattery
{
    public EntityMetaData<T> MetaData => entityMetaData;
    public BatterySpecification Specification => batterySpecification;
    
    // current battery charge in A*h
    private float _currentCharge = currentCharge;
}