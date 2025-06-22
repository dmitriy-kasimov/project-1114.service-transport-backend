using transport.domain.core.Overland.modules.Axis.dto;

namespace transport.domain.core.Overland.modules.Axis;

public class Axis<TA>(AxisParams<TA> axisParams)
{
    private AxisParams<TA> _axisParams = axisParams;
}