namespace transport.domain.core.Mechanical.modules.Battery.dto;

public class BatteryParams(EntityMetaData entityMetaData,  BatterySpecification batterySpecification, float currentCharge = 0.0f) : IEntity, IBattery
{
    public EntityMetaData MetaData => entityMetaData;
    public BatterySpecification Specification => batterySpecification;
    
    // current battery charge in A*h
    private float _currentCharge = currentCharge;
}