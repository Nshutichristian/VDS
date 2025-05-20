using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeSnapshot : MonoBehaviour
{
    public Camera snapCamera;
    public RenderTexture snapTexture;

    public void Capture()
    {
        snapCamera.targetTexture = snapTexture;
        snapCamera.Render();
        snapCamera.targetTexture = null;
    }
}

