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
    public Task<Wagon<T,TA>?> Create(Player player,  Models model);
    
    public Task<Battery<Models>?> GetBatteryByModelAsync(string model);
    public Task AddBatteryAsync(ModuleMetaData<Models> metaData, BatterySpecification specification);
    
    public Task<Engine<T, Models>?> GetEngineByModelAsync(string model);
    public Task AddEngineAsync(ModuleMetaData<Models> metaData, EngineSpecification<T> specification);
    
    public Task<Petrol<T, Models>?> GetPetrolByModelAsync(string model);

    public Task AddPetrolAsync(ModuleMetaData<Models> metaData, PetrolSpecification specification);
    
    public Task<Axis<TA, Models>?> GetAxisByModelAsync(string model);
    public Task AddAxisAsync(ModuleMetaData<Models> metaData, AxisSpecification<TA> specification);
    
}