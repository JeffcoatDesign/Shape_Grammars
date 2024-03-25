using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Building Generation/Building Settings")]
public class BuildingSettings : ScriptableObject
{
    public Vector2Int buildingSize;
    public RoofStrategy roofStrategy;
    public WallsStrategy wallsStrategy;
    public StoriesStrategy storiesStrategy;
    public StoryStrategy storyStrategy;
    public WingsStrategy wingsStrategy;
    public WingStrategy wingStrategy;
    public Vector2Int Size { get { return buildingSize; } }
    public int numberOfStories = 1;
    public int numberOfWings = 1;
    public void SetWidth (int width)
    {
        buildingSize.x = width;
    }
    public void SetLength (int length)
    {
        buildingSize.y = length;
    }
}
