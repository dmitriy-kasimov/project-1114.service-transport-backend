using transport.domain.core.IMechanical.Platform;

namespace transport.domain.core.IMechanical;

public interface IMechanical
{
    public IPlatform Platform { get; set; }
}