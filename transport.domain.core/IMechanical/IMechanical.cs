using transport.domain.core.IMechanical.IPlatform;

namespace transport.domain.core.IMechanical;

public interface IMechanical
{
    public IPlatform.IPlatform Platform { get; set; }
}