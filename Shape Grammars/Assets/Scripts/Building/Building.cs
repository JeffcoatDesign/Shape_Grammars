using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building
{
    Vector2Int size;
    Wing[] wings;

    public Vector2Int Size { get { return size; } }
    public Wing[] Wings { get { return wings; } }

    public Building(int sizeX, int sizeY, Wing[] wings) {
        size = new Vector2Int(sizeX, sizeY);
        this.wings = wings;
    }

    public override string ToString()
    {
        string building = $"Building({size.ToString()}; {wings.Length})\n";
        foreach (var wing in wings)
        {
            building += "\t" + wing.ToString() + "\n";
        }
        return building;
    }
}
