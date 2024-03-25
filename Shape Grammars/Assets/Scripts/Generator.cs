using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Generator
{
    public static Building Generate(BuildingSettings settings)
    {
        return new Building(settings.Size.x, settings.Size.y, settings.wingsStrategy != null ? settings.wingsStrategy.GenerateWings(settings) : ScriptableObject.CreateInstance<DefaultWingsStrategy>().GenerateWings(settings));
    }

    //static Wing[] GenerateWings (BuildingSettings settings)
    //{
    //    RectInt bounds = new RectInt(0, 0, settings.Size.x, settings.Size.y);
    //    int height = 1;
    //    return new Wing[]
    //        {
    //            settings.wingStrategy != null ? settings.wingStrategy.GenerateWing(settings,bounds, height) : ScriptableObject.CreateInstance<DefaultWingStrategy>().GenerateWing(settings,bounds,height)
    //        };
    //}

    //static Wing GenerateWing (BuildingSettings settings, RectInt bounds, int numberOfStories)
    //{
    //    return new Wing(bounds,
    //                settings.storiesStrategy != null ? settings.storiesStrategy.GenerateStories(settings,bounds,numberOfStories) : ScriptableObject.CreateInstance<DefaultStoriesStrategy>().GenerateStories(settings,bounds,numberOfStories),
    //                settings.roofStrategy != null ? settings.roofStrategy.GenerateRoof(settings, bounds) : ScriptableObject.CreateInstance<DefaultRoofStrategy>().GenerateRoof(settings, bounds));
    //}

    //static Story[] GenerateStories (BuildingSettings settings, RectInt bounds, int numberOfStories)
    //{
    //    return new Story[] {
    //        settings.storyStrategy != null ? settings.storyStrategy.GenerateStory(settings, bounds, numberOfStories) : ScriptableObject.CreateInstance<DefaultStoryStrategy>().GenerateStory(settings,bounds, numberOfStories)
    //    };
    //}

    //static Story GenerateStory (BuildingSettings settings, RectInt bounds, int level)
    //{
    //    return new Story(0, settings.wallsStrategy != null ? settings.wallsStrategy.GenerateWalls(settings, bounds, level) : ScriptableObject.CreateInstance<DefaultWallsStrategy>().GenerateWalls(settings,bounds,level));
    //}

    //static Wall[] GenerateWalls (BuildingSettings settings, RectInt bounds, int level)
    //{
    //    return new Wall[(bounds.size.x + bounds.size.y) * 2];
    //}

    //static Roof GenerateRoof(BuildingSettings settings, RectInt bounds)
    //{
    //    Roof roof = new Roof();
    //    return roof;
    //}
}
