using transport.domain.core.subsection.Mechanical.Platform;

namespace transport.domain.core.subsection.Mechanical;

public interface IMechanical
{
    public IPlatform Platform { get; set; }
}