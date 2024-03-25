using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultWingsStrategy : WingsStrategy
{
    public override Wing[] GenerateWings(BuildingSettings settings)
    {
        RectInt bounds = new RectInt(0, 0, settings.Size.x, settings.Size.y);
        int height = 1;
        return new Wing[]
            {
                settings.wingStrategy != null ? settings.wingStrategy.GenerateWing(settings,bounds, height) : CreateInstance<DefaultWingStrategy>().GenerateWing(settings,bounds,height)
            };
    }
}
