namespace transport.services.interfaces;

public interface IFuelTransportInteraction : ITransportInteraction
{
    public float getFuelTankCapacity();
    public float getFuel();
}