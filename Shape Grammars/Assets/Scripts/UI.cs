using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    Builder builder;
    public BuildingSettings settings;
    private void Awake()
    {
        builder = GetComponent<Builder>();
    }
    public void Generate()
    {
        Building building = Generator.Generate(settings);
        Debug.Log(building);
        builder.Render(building);
    }
}
