using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Color newColor = Color.red; // Set the desired color in Inspector

    void Start()
    {
        Renderer rend = GetComponent<Renderer>();
        if (rend != null)
        {
            rend.material.color = newColor;
        }
    }

    // You can also call this method via a button or event:
    public void ChangeColor(Color color)
    {
        Renderer rend = GetComponent<Renderer>();
        if (rend != null)
        {
            rend.material.color = color;
        }
    }
}
