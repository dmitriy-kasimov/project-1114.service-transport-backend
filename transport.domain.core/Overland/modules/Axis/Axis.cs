namespace transport.domain.core.Overland.modules.Axis;

// TODO Nullable List<decimal> state
public class Axis<T>(EntityMetaData entityMetaData, AxisSpecification<T> axisSpecification, List<decimal> state): IEntity, IAxis<T>
{
    public EntityMetaData MetaData => entityMetaData;
    public AxisSpecification<T> Specification => axisSpecification;
    
    private List<decimal> _state = state;
}