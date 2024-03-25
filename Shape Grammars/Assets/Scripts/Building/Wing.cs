using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wing
{
    RectInt bounds;
    Story[] stories;
    Roof roof;
    int wingNumber;

    public RectInt Bounds { get => bounds; }
    public Story[] Stories { get => stories; }
    public Roof GetRoof { get => roof; }
    public int WingNumber { get => wingNumber; }

    public Wing(RectInt bounds)
    {
        this.bounds = bounds;
    }

    public Wing(RectInt bounds, Story[] stories, Roof roof, int wingNumber) {
        this.bounds = bounds;
        this.stories = stories;
        this.roof = roof;
        this.wingNumber = wingNumber;
    }

    public override string ToString()
    {
        string wing = $"Wing({bounds.ToString()}):\n";
        foreach (var story in stories) { wing += "\t" + story.ToString() + "\n"; }
        wing += "\t" + roof.ToString() + "\n";
        return wing;
    }
}