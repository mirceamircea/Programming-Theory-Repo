using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    // INHERITANCE

    // POLYMORPHISM
    protected override void OnMouseDownHook()
    {
        float randomTransparency = GenerateRandomTransparency();
        SetTransparency(randomTransparency);
        SetShapeColor();

        DisplayText();
    }

    // ENCAPSULATION
    private float GenerateRandomTransparency()
    {
        return Random.Range(0.0f, 1.0f);
    }

    // ENCAPSULATION
    private void SetTransparency(float transparency)
    {
        ShapeColor = new Color(ShapeColor.r, ShapeColor.g, ShapeColor.b, transparency);
    }

    // POLYMORPHISM
    protected override void DisplayText()
    {
        text.SetText(ShapeName + ": " + ShapeColor.ToString());
    }
}
