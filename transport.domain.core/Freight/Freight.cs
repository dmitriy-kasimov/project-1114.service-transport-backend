using transport.domain.core.Freight.IFreight;

namespace transport.domain.core.Freight;

public class Freight : IMechanical.IMechanical, IGround.IGround, IFreight.IFreight
{
    public Axis Axis { get; set; }
}