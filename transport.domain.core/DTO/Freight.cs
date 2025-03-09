using AltV.Net;

namespace transport.domain.core.DTO;

public class Freight : Transport
{
    public Freight(ICore core, IntPtr nativePointer, uint id) : base(core, nativePointer, id)
    {
        
    }
}