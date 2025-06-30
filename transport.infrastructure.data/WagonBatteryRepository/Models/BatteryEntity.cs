namespace transport.infrastructure.data.WagonBatteryRepository.Models;

public class BatteryEntity
{
    public Guid Id { get; set; }
    public string Model { get; set; } = string.Empty;
    public string Name { get; set;} = string.Empty;
    public decimal MaxCharge { get; set; } = decimal.Zero;
    // хранить список совместимых тс
}