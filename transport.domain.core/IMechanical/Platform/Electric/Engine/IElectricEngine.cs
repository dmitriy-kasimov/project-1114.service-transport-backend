namespace transport.domain.core.IMechanical.Platform.Electric.Engine;

public interface IElectricEngine : IEngine
{
    public new string Name { get; }
    public new string Description { get; }
}