namespace transport.domain.core.Wagon.dto;

public class WagonParams(Models model, Transport.Transport? trailer)
{
    public Models Model => model;
    
    // TODO define Transport.Transport on class of Trailers 
    private Transport.Transport? _trailer = trailer;
}