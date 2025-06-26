namespace transport.domain.core.Overland.modules.Axis.dto;

public class AxisParams<T>(EntityMetaData entityMetaData, AxisSpecification<T> axisSpecification, float[] state) : IEntity, IAxis<T>
{
    public EntityMetaData MetaData => entityMetaData;
    public AxisSpecification<T> Specification => axisSpecification;
    
    private float[] _state = state;
} 