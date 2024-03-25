using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultWallsStrategy : WallsStrategy
{
    bool hasDoor = false;
    public override Wall[] GenerateWalls(BuildingSettings settings, RectInt bounds, int level)
    {
        Wall[] walls = new Wall[(bounds.size.x + bounds.size.y) * 2];
        for (int i = 0; i < walls.Length; i++)
        {
            if (level == 0)
            {
                if (!hasDoor)
                {
                    hasDoor = true;
                    walls[i] = (Wall)Random.Range(3, 5);
                }
                else
                {
                    walls[i] = (Wall)Random.Range(0, 3);
                }
            }
            else
                walls[i] = (Wall)Random.Range(0, 2);
        }
        return walls;
    }
}
