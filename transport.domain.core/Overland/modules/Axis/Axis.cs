using transport.domain.core.Overland.modules.Axis.dto;

namespace transport.domain.core.Overland.modules.Axis;

public class Axis<T>(EntityMetaData entityMetaData, AxisSpecification<T> axisSpecification, float[] state): IEntity, IAxis<T>
{
    public EntityMetaData MetaData => entityMetaData;
    public AxisSpecification<T> Specification => axisSpecification;
    
    private float[] _state = state;
}