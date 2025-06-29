namespace transport.domain.core.Mechanical.modules.Engine;

public class EngineSpecification<T>(decimal bsfc, List<T> acceptedTypesFuel)
{
    // Brake-Specific Fuel Consumption (BSFC): How much fuel is used per unit of power (g/kWh).
    public decimal Bsfc => bsfc;

    public List<T> AcceptedTypesFuel => acceptedTypesFuel;
}

public interface IEngine<T>
{
    public EngineSpecification<T> Specification { get; }
}