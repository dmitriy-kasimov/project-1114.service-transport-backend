using AltV.Net.Elements.Entities;
using transport.domain.core;
using transport.domain.core.Mechanical.modules.Battery;
using transport.domain.core.Mechanical.modules.Engine;
using transport.domain.core.Mechanical.modules.Petrol;
using transport.domain.core.Overland.modules.Axis;
using transport.domain.core.Wagon;

namespace transport.domain.interfaces;

public interface IWagonRepository<T, TA>
{
    public Task<Wagon<T, TA>?> Spawn(Models model, Player? player = null);
        
    //
    
    public Task AddWagonAsync(Models model);
   
    //
    
    public Task<Battery<Models>?> GetBatteryByNameAsync(string name);
    public Task AddBatteryAsync(Battery<Models> battery);
    
    public Task<Engine<T, Models>?> GetEngineByNameAsync(string name);
    public Task AddEngineAsync(Engine<T, Models> engine);
    
    public Task<Petrol<T, Models>?> GetPetrolByNameAsync(string name);

    public Task AddPetrolAsync(Petrol<T, Models> petrol);
    
    public Task<Axis<TA, Models>?> GetAxisByNameAsync(string name);
    public Task AddAxisAsync(Axis<TA, Models> axis);
    
    //

    public Task LinkWagonToAxis(Models model, string moduleName);
    public Task LinkWagonToBattery(Models model, string moduleName);
    public Task LinkWagonToEngine(Models model, string moduleName);
    public Task LinkWagonToPetrol(Models model, string moduleName);
}