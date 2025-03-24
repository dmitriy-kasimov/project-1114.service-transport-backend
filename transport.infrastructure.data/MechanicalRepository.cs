using transport.domain.core.IMechanical;
using transport.domain.interfaces;

namespace transport.infrastructure.data;

public class MechanicalRepository : IMechanicalRepository
{
    public bool StartEngine(IMechanical mechanical)
    {
        return true;
    }

    public bool StopEngine(IMechanical mechanical)
    {
        return true;
    }
}