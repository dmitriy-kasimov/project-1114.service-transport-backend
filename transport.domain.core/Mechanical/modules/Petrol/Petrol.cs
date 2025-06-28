namespace transport.domain.core.Mechanical.modules.Petrol;

public class Petrol<T>(EntityMetaData entityMetaData,  PetrolSpecification petrolSpecification, T? fuelType, float amountFuel = 0.0f): IEntity, IPetrol
{
    public EntityMetaData MetaData => entityMetaData;
    public PetrolSpecification Specification => petrolSpecification;
    
    private T? _fuelType = fuelType;
    private float _amountFuel = amountFuel;
}