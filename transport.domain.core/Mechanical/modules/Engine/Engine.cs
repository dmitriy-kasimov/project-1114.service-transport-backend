using transport.domain.core.Mechanical.modules.Engine.dto;

namespace transport.domain.core.Mechanical.modules.Engine;

public class Engine<T>(EngineParams<T> engineParams)
{
    private readonly EngineParams<T> _engineParams = engineParams;
}