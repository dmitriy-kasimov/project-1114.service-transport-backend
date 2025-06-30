namespace transport.infrastructure.data.WagonPetrolRepository.Models;

public class PetrolEntity
{
    public Guid Id { get; set; }
    public string Model { get; set; } = string.Empty;
    public string Name { get; set;} = string.Empty;
    public decimal Capacity { get; set; } = decimal.Zero;
}