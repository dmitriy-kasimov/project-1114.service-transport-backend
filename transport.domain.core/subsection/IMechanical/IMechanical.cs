using transport.domain.core.subsection.IMechanical.Platform;

namespace transport.domain.core.subsection.IMechanical;

public interface IMechanical
{
    public IPlatform Platform { get; set; }
}