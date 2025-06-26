namespace transport.domain.core.Mechanical.modules.Engine.dto;

public class EngineParams<T>(EntityMetaData entityMetaData, EngineSpecification<T> engineSpecification) : IEntity, IEngine<T>
{
    public EntityMetaData MetaData => entityMetaData;
    
    public EngineSpecification<T> Specification => engineSpecification;
}