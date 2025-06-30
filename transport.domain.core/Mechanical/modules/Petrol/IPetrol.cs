namespace transport.domain.core.Mechanical.modules.Petrol;

public class PetrolSpecification(decimal capacity)
{
    public decimal Capacity => capacity;
}

public interface IPetrol
{
    public PetrolSpecification Specification { get;}
}