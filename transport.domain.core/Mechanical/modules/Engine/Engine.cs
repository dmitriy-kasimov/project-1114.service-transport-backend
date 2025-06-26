using transport.domain.core.Mechanical.modules.Engine.dto;

namespace transport.domain.core.Mechanical.modules.Engine;

public class Engine<T>(EngineParams<T> parameters)
{
    public EngineParams<T> Params => parameters;
}