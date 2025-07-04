namespace transport.infrastructure.data.WagonRepository.Models;

public class BatteryEntity
{
    public Guid Id { get; set; }
    public string Name { get; set;} = string.Empty;
    public decimal MaxCharge { get; set; } = decimal.Zero;
    
    public List<WagonEntity> CompatibleTransports { get; set; } = [];
}