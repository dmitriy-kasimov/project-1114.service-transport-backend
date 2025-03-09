namespace transport.domain.interfaces;

public interface IFuelTransportRepository : ITransportRepository
{
    public float getFuelTankCapacity();
    public float getFuel();
}