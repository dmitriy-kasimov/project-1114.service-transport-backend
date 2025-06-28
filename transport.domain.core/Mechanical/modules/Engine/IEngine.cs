namespace transport.domain.core.Mechanical.modules.Engine;

public class EngineSpecification<T>(float bsfc, T[] acceptedTypesFuel)
{
    // Brake-Specific Fuel Consumption (BSFC): How much fuel is used per unit of power (g/kWh).
    public float Bsfc => bsfc;

    public T[] AcceptedTypesFuel => acceptedTypesFuel;
}

public interface IEngine<T>
{
    public EngineSpecification<T> Specification { get; }
}