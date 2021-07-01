using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class Shape : MonoBehaviour
{
    [SerializeField]
    protected TextMeshProUGUI text;
    [SerializeField]
    private string name;
    [SerializeField]
    private Color color;

    // ENCAPSULATION
    public string ShapeName {
        get { return name; }
        set { name = value; }
    }
    public Color ShapeColor {
        get { return color; }
        set { color = value; }
    }

    // ABSTRACTION
    private void OnMouseDown()
    {
        OnMouseDownHook();
        DisplayText();
    }

    // ABSTRACTION
    protected virtual void DisplayText()
    {
        text.SetText("You clicked on the " + ShapeName + " with the color " + ShapeColor.ToString());
    }

    // Start is called before the first frame update
    void Start()
    {
        SetShapeColor();
    }

    // ABSTRACTION
    protected void SetShapeColor()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = ShapeColor;
    }

    // ABSTRACTION
    protected abstract void OnMouseDownHook();
}
