using transport.domain.core.subsection.Mechanical.Platform;

namespace transport.domain.core.subsection.Mechanical;

public class Mechanical
{
    public IPlatform Platform { get; set; }
    
    public Mechanical(IPlatform platform)
    {
        Platform = platform;
    }
}