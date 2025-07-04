namespace transport.domain.core;

public class ModuleMetaData<T>(Guid id, string name, List<T> compatiblyTransports)
{
    public Guid Id => id;
    public string Name => name;
    public List<T> CompatiblyTransports => compatiblyTransports;
}

public interface IModule<T>
{
    public ModuleMetaData<T> MetaData { get; }
}