namespace transport.domain.core;

public class EntityMetaData(string model, string name)
{
    public string Model => model;
    public string Name => name;
}

public interface IEntity
{
    public EntityMetaData MetaData { get; }
}