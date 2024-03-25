using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultWingStrategy : WingStrategy
{
    public override Wing GenerateWing(BuildingSettings settings, RectInt bounds, int numberOfStories)
    {
        return new Wing(bounds,
                    settings.storiesStrategy != null ? settings.storiesStrategy.GenerateStories(settings, bounds, numberOfStories) : CreateInstance<DefaultStoriesStrategy>().GenerateStories(settings, bounds, numberOfStories),
                    settings.roofStrategy != null ? settings.roofStrategy.GenerateRoof(settings, bounds) : CreateInstance<DefaultRoofStrategy>().GenerateRoof(settings, bounds));
    }
}
