namespace transport.domain.core.Mechanical.modules.Petrol;

// TODO обкашлять Nullable для fuelType параметра 
public class Petrol<T, TA>(ModuleMetaData<TA> moduleMetaData,  PetrolSpecification petrolSpecification, T? fuelType, float amountFuel = 0.0f): IModule<TA>, IPetrol
{
    public ModuleMetaData<TA> MetaData => moduleMetaData;
    public PetrolSpecification Specification => petrolSpecification;
    
    private T? _fuelType = fuelType;
    private float _amountFuel = amountFuel;
}