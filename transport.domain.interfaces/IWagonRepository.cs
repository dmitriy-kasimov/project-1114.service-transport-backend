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
    public Task<Wagon<T, TA, TE>?> Create(Player player,  Models model);
    
    public Task<Battery<TE>?> GetBatteryByNameAsync(string name);
    public Task AddBatteryAsync(Battery<TE> battery);
    
    public Task<Engine<T, TE>?> GetEngineByNameAsync(string name);
    public Task AddEngineAsync(Engine<T, TE> engine);
    
    public Task<Petrol<T, TE>?> GetPetrolByNameAsync(string name);

    public Task AddPetrolAsync(Petrol<T, TE> petrol);
    
    public Task<Axis<TA, TE>?> GetAxisByNameAsync(string name);
    public Task AddAxisAsync(Axis<TA, TE> axis);
    
}