using AltV.Net.Elements.Entities;
using transport.domain.core;
using transport.domain.core.Mechanical.modules.Battery;
using transport.domain.core.Mechanical.modules.Engine;
using transport.domain.core.Mechanical.modules.Petrol;
using transport.domain.core.Overland.modules.Axis;
using transport.domain.core.Wagon;

namespace transport.domain.interfaces;

public interface IWagonRepository<T, TA, TE>
{
    public Task AddWagonAsync(Models model);
    public Task<TE?> GetWagonByModel(Models model);
    public Task<Wagon<T, TA>?> Spawn(Models model, Player? player = null);
    
    public Task<Battery<Models>?> GetBatteryByNameAsync(string name);
    public Task AddBatteryAsync(Battery<Models> battery, List<TE>? compatibleWagons = null);
    
    public Task<Engine<T, Models>?> GetEngineByNameAsync(string name);
    public Task AddEngineAsync(Engine<T, Models> engine, List<TE>? compatibleWagons = null);
    
    public Task<Petrol<T, Models>?> GetPetrolByNameAsync(string name);

    public Task AddPetrolAsync(Petrol<T, Models> petrol, List<TE>? compatibleWagons = null);
    
    public Task<Axis<TA, Models>?> GetAxisByNameAsync(string name);
    public Task AddAxisAsync(Axis<TA, Models> axis, List<TE>? compatibleWagons = null);
    
}