namespace transport.infrastructure.data.WagonRepository.Models;

public class PetrolEntity
{
    public string Name { get; set;} = string.Empty;
    public decimal Capacity { get; set; } = decimal.Zero;
    
    public List<WagonEntity> CompatibleTransports { get; set; } = [];
}