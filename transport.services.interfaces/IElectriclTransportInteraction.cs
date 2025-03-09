namespace transport.services.interfaces;

public interface IElectricTransportInteraction : ITransportInteraction
{
    public float getBatteryCapacity();
    public float getBattery();
}