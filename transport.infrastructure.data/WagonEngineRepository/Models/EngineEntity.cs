namespace transport.infrastructure.data.WagonEngineRepository.Models;

public class EngineEntity<T>
{
    public Guid Id { get; set; }
    public string Model { get; set; } = string.Empty;
    public string Name { get; set;} = string.Empty;
    public decimal Bsfc { get; set;} = decimal.Zero;
    public List<T> AcceptedTypesFuel { get; set; } = [];
    // хранить список совместимых тс
}