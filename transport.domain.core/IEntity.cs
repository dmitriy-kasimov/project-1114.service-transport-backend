namespace transport.domain.core;

public class EntityMetaData(string id, string model, string name)
{
    public string Id => id;
    public string Model => model;
    public string Name => name;
}

public interface IEntity
{
    public EntityMetaData MetaData { get; }
}