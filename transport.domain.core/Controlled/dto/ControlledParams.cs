using AltV.Net.Elements.Entities;

namespace transport.domain.core.Controlled.dto;

public class ControlledParams(float mileage = 0.0f)
{
    private float _mileage = mileage;
}