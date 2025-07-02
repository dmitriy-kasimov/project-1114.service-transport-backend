using transport.domain.core.Overland.modules;
using transport.domain.core.Overland.modules.Axis;

namespace transport.domain.core.Overland.dto;

public class OverlandParams<T, TA>(List<string> compatibleAxis, string defaultAxisModel, Axis<T, TA> axis)
{
    public List<string> CompatibleAxis => compatibleAxis;
    
    public string DefaultAxisModel => defaultAxisModel;
    
    public Axis<T, TA> Axis => axis;
}