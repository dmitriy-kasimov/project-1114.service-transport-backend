namespace transport.domain.interfaces;

public interface IElectricTransportRepository : ITransportRepository
{
    public float getBatteryCapacity();
    public float getBattery();
}