namespace transport.domain.core.Mechanical.modules.Engine;

public class Engine<T, TA>(ModuleMetaData<TA> moduleMetaData, EngineSpecification<T> engineSpecification): IModule<TA>, IEngine<T>
{
    public ModuleMetaData<TA> MetaData => moduleMetaData;
    
    public EngineSpecification<T> Specification => engineSpecification;
}