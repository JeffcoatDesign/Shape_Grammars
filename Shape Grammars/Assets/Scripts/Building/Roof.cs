using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roof {
    RoofType type;
    RoofDirection direction;

    public RoofType Type { get => type; }
    public RoofDirection Direction { get => direction; }

    public Roof(RoofType type = RoofType.Flat, RoofDirection direction = RoofDirection.North) {
        this.type = type;
        this.direction = direction;
    }

    public override string ToString()
    {
        return "Roof: " + type.ToString() + " " + direction.ToString();
    }
}

public enum RoofType {
    Flat,
    Point,
    Slant
}

public enum RoofDirection {
    North, //posZ
    East, //posX
    South, //negZ
    West //negX
}