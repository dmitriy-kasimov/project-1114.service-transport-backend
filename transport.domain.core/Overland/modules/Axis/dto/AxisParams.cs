namespace transport.domain.core.Overland.modules.Axis.dto;

public class AxisParams<TA>(ushort id, string model, string name, TA axis, float[] state) : IEntity
{
    public ushort Id => id;
    public string Model => model;
    public string Name => name;
    
    private TA _axis = axis;
    private float[] _state = state;
}