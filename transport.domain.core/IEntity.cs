namespace transport.domain.core;

public interface IEntity
{
    ushort Id { get; } 
    string Model { get; }
    string Name { get; }
}