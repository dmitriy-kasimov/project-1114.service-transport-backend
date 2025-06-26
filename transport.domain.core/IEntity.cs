namespace transport.domain.core;

public class EntityMetaData(ushort id, string model, string name)
{
    public ushort Id => id;
    public string Model => model;
    public string Name => name;
}

public interface IEntity
{
    public EntityMetaData MetaData { get; }
}