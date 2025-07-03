namespace transport.infrastructure.data.WagonRepository.Models;

public class BatteryEntity
{
    public Guid Id { get; set; }
    public string Model { get; set; } = string.Empty;
    public string Name { get; set;} = string.Empty;
    public decimal MaxCharge { get; set; } = decimal.Zero;
    
    public List<domain.core.Wagon.Models> CompatibleTransports { get; set; } = [];
    public List<WagonEntity> CompatibleWagons { get; set; } = [];
}