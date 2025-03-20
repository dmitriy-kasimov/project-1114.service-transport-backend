using AltV.Net;
using AltV.Net.Enums;
using transport.domain.core.Freight.Axis;
using transport.domain.core.IGround.IChassis;
using transport.domain.core.IMechanical.IPlatform;

namespace transport.domain.core.Freight;

public class Freight : Transport, IMechanical.IMechanical, IGround.IGround, IFreight.IFreight
{
    public IAxis Axis { get; }
    public IPlatform Platform { get; }
    public IChassis Chassis { get; }
    
    public Freight(ICore core, IntPtr nativePointer, uint id) : base(core, nativePointer, id)
    {
        
    }
}