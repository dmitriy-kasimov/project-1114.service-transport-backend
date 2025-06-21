namespace transport.domain.core.Mechanical.modules.Engine.dto;

public abstract class EngineParams(float bsfc)
{
    // Brake-Specific Fuel Consumption (BSFC): How much fuel is used per unit of power (g/kWh).
    private float _bsfc = bsfc;
}