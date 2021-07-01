using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    // INHERITANCE

    // POLYMORPHISM
    protected override void OnMouseDownHook()
    {
        Color randomColor = GenerateRandomColor(); Debug.Log(randomColor.ToString());
        ShapeColor = randomColor;
        SetShapeColor();

        DisplayText();
    }

    // ENCAPSULATION
    private Color GenerateRandomColor()
    {
        return new Color(
            Random.Range(0.0f, 1.0f),
            Random.Range(0.0f, 1.0f),
            Random.Range(0.0f, 1.0f)
        );
    }
}
