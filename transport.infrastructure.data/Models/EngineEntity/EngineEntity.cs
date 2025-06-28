namespace transport.infrastructure.data.Models.EngineEntity;

public class EngineEntity
{
    public Guid Id { get; set; }
    public string Model { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public decimal Bsfc { get; set; } = decimal.Zero;
    public int[] AcceptedTypesFuel { get; set; } = [];
}