namespace transport.infrastructure.data.Models;

public class EngineEntity<T>
{
    public Guid Id { get; set; }
    public string Model { get; } = string.Empty;
    public string Name { get; } = string.Empty;
    public decimal Bsfc { get; } = decimal.Zero;
    public List<T> AcceptedTypesFuel { get; } = [];
    // хранить список совместимых тс
}