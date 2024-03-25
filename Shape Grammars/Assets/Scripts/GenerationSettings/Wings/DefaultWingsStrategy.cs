using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultWingsStrategy : WingsStrategy
{
    public override Wing[] GenerateWings(BuildingSettings settings)
    {
        Wing[] wings = new Wing[settings.numberOfWings];
        RectInt bounds = new RectInt(0, 0, settings.Size.x, settings.Size.y);
        int height = settings.numberOfStories;
        for (int i = 0; i < settings.numberOfWings; i++)
        {
            wings[i] = settings.wingStrategy != null ? settings.wingStrategy.GenerateWing(settings, bounds, height, i) : CreateInstance<DefaultWingStrategy>().GenerateWing(settings, bounds, height, i);
        }
        return wings;
    }
}
