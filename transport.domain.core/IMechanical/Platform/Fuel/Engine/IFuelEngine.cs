namespace transport.domain.core.IMechanical.Platform.Fuel.Engine;

public interface IFuelEngine : IEngine
{
    public new string Name { get; }
    public new string Description { get; }
}