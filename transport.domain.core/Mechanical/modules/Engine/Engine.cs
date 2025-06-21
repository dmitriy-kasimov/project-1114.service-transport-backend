using transport.domain.core.Mechanical.modules.Engine.dto;

namespace transport.domain.core.Mechanical.modules.Engine;

public class Engine(EngineParams engineParams)
{
    private readonly EngineParams _engineParams = engineParams;
}