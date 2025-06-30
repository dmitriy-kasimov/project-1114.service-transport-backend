namespace transport.infrastructure.data.WagonAxisRepository.Models;

public class AxisEntity<T>
{
    public Guid Id { get; set; }
    public string Model { get; set; } = string.Empty;
    public string Name { get; set;} = string.Empty;
    public T Axis { get; set; } = default!;
    // хранить список совместимых тс
}