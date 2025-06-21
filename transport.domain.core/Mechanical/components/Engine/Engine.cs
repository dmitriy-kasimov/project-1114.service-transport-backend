using transport.domain.core.Mechanical.components.Engine.dto;

namespace transport.domain.core.Mechanical.components.Engine;

public class Engine(EngineParams engineParams)
{
    private readonly EngineParams _engineParams = engineParams;
}