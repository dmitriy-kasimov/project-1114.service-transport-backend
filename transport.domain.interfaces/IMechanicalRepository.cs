namespace transport.domain.interfaces;

public interface IMechanicalRepository
{
    public bool StartEngine();
    public bool StopEngine();
}