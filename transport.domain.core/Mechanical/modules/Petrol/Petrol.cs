namespace transport.domain.core.Mechanical.modules.Petrol;

// TODO обкашлять Nullable для fuelType параметра 
public class Petrol<T, TA>(EntityMetaData<TA> entityMetaData,  PetrolSpecification petrolSpecification, T? fuelType, float amountFuel = 0.0f): IEntity<TA>, IPetrol
{
    public EntityMetaData<TA> MetaData => entityMetaData;
    public PetrolSpecification Specification => petrolSpecification;
    
    private T? _fuelType = fuelType;
    private float _amountFuel = amountFuel;
}