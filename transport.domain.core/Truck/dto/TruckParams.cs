namespace transport.domain.core.Truck.dto;

public class TruckParams(float curbWeight, float maxGrossWeight)
{
    // Weight of the truck without cargo.
    private float _curbWeight = curbWeight;

    // Total allowable weight (truck + cargo).
    private float _maxGrossWeight = maxGrossWeight;

}