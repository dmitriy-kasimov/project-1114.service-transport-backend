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
    public Wagon<T,TA> Create(Player player,  Models model);
    public Wagon<T,TA> Create(Player player,  Models model, Engine<T> engine, Petrol<T> petrol, Battery battery, Axis<TA> axis);
    
    public Task<Battery?> GetBatteryByModelAsync(string model);
    public Task AddBatteryAsync(EntityMetaData entityMetaData, BatterySpecification batterySpecification);
    
    public Task<Engine<T>?> GetEngineByModelAsync(string model);
    public Task AddEngineAsync(EntityMetaData entityMetaData, EngineSpecification<T> specification);
    
    public Task<Petrol<T>?> GetPetrolByModelAsync(string model);

    public Task AddPetrolAsync(EntityMetaData entityMetaData, PetrolSpecification petrolSpecification);
    
    public Task<Axis<TA>?> GetAxisByModelAsync(string model);
    public Task AddAxisAsync(EntityMetaData entityMetaData, AxisSpecification<TA> axisSpecification);
    
}