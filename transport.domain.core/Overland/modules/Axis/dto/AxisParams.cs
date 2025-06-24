namespace transport.domain.core.Overland.modules.Axis.dto;

public class AxisParams<TA>(TA axis, float[] state)
{
    private TA _axis = axis;
    private float[] _state = state;
}