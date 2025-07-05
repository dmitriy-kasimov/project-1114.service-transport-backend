namespace transport.domain.core;

public class ModuleMetaData<T>(string name, List<T> compatiblyTransports)
{
    public string Name => name;
    public List<T> CompatiblyTransports => compatiblyTransports;
}

public interface IModule<T>
{
    public ModuleMetaData<T> MetaData { get; }
}