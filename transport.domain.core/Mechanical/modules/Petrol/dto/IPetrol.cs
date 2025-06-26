namespace transport.domain.core.Mechanical.modules.Petrol.dto;

public class PetrolSpecification(float maxFuel)
{
    public float MaxFuel => maxFuel;
}

public interface IPetrol
{
    public PetrolSpecification Specification { get;}
}