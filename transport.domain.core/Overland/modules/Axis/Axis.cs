namespace transport.domain.core.Overland.modules.Axis;

// TODO Nullable List<decimal> state
public class Axis<T, TA>(EntityMetaData<TA> entityMetaData, AxisSpecification<T> axisSpecification, List<decimal> state): IEntity<TA>, IAxis<T>
{
    public EntityMetaData<TA> MetaData => entityMetaData;
    public AxisSpecification<T> Specification => axisSpecification;
    
    private List<decimal> _state = state;
}