namespace transport.domain.core.Mechanical.modules.Engine;

public class Engine<T, TA>(EntityMetaData<TA> entityMetaData, EngineSpecification<T> engineSpecification): IEntity<TA>, IEngine<T>
{
    public EntityMetaData<TA> MetaData => entityMetaData;
    
    public EngineSpecification<T> Specification => engineSpecification;
}