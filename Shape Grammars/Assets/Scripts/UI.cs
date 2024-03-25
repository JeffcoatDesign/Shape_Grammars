using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    Builder builder;
    public BuildingSettings settings;
    public TextMeshProUGUI widthText;
    public TextMeshProUGUI lengthText;
    public TextMeshProUGUI storiesText;
    public TextMeshProUGUI wingsText;
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
    public void SetWidth(float width)
    {
        widthText.text = ((int)width).ToString();
        settings.SetWidth((int)width);
    }

    public void SetLength(float length)
    {
        lengthText.text = ((int)length).ToString();
        settings.SetLength(((int)length));
    }
    public void SetStories(float stories)
    {
        storiesText.text = ((int)stories).ToString();
        settings.numberOfStories = (int)stories;
    }
    public void SetWings(float wings)
    {
        wingsText.text = ((int)wings).ToString();
        settings.numberOfWings = (int)wings;
    }
}
