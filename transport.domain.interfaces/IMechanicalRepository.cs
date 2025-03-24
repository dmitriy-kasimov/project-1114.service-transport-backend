using transport.domain.core.IMechanical;

namespace transport.domain.interfaces;

public interface IMechanicalRepository
{
    public bool StartEngine(IMechanical mechanical);
    public bool StopEngine(IMechanical mechanical);
}