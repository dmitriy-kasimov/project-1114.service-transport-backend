namespace transport.domain.core.Overland.modules.Axis;

// TODO Nullable List<decimal> state
public class Axis<T, TA>(ModuleMetaData<TA> moduleMetaData, AxisSpecification<T> axisSpecification, List<decimal> state): IModule<TA>, IAxis<T>
{
    public ModuleMetaData<TA> MetaData => moduleMetaData;
    public AxisSpecification<T> Specification => axisSpecification;
    
    private List<decimal> _state = state;
}