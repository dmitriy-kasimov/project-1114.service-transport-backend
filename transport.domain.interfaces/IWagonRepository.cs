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
    // public Wagon<T,TA> Create(Player player,  Models model);
    public Wagon<T,TA> Create(Player player,  Models model, Engine<T, Models> engine, Petrol<T, Models> petrol, Battery<Models> battery, Axis<TA, Models> axis);
    
    public Task<Battery<Models>?> GetBatteryByModelAsync(string model);
    public Task AddBatteryAsync(EntityMetaData<Models> entityMetaData, BatterySpecification batterySpecification);
    
    public Task<Engine<T, Models>?> GetEngineByModelAsync(string model);
    public Task AddEngineAsync(EntityMetaData<Models> entityMetaData, EngineSpecification<T> specification);
    
    public Task<Petrol<T, Models>?> GetPetrolByModelAsync(string model);

    public Task AddPetrolAsync(EntityMetaData<Models> entityMetaData, PetrolSpecification petrolSpecification);
    
    public Task<Axis<TA, Models>?> GetAxisByModelAsync(string model);
    public Task AddAxisAsync(EntityMetaData<Models> entityMetaData, AxisSpecification<TA> axisSpecification);
    
}