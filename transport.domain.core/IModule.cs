namespace transport.domain.core;

public class ModuleMetaData<T>(string model, string name, List<T> compatiblyTransports)
{
    public string Model => model;
    public string Name => name;
    public List<T> CompatiblyTransports => compatiblyTransports;
}

public interface IModule<T>
{
    public ModuleMetaData<T> MetaData { get; }
}