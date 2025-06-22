namespace transport.domain.core.Overland.modules.Axis.dto;

public abstract class AxisParams<TA>(TA axis, float[] state)
{
    private TA _axis = axis;
    private float[] _state = state;
}