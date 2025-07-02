namespace transport.domain.core;

public class EntityMetaData<T>(string model, string name, List<T> compatiblyTransports)
{
    public string Model => model;
    public string Name => name;
    public List<T> CompatiblyTransports => compatiblyTransports;
}

public interface IEntity<T>
{
    public EntityMetaData<T> MetaData { get; }
}