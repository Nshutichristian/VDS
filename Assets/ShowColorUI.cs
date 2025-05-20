using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShowColorUI : MonoBehaviour
{
    public GameObject colorUI;  // Drag your UI panel here in Unity
    public InputActionReference toggleAction;  // Assign the Y button (e.g., XRI RightHand Menu)

    void OnEnable()
    {
        if (toggleAction != null)
            toggleAction.action.performed += ToggleUI;
    }

    void OnDisable()
    {
        if (toggleAction != null)
            toggleAction.action.performed -= ToggleUI;
    }

    void ToggleUI(InputAction.CallbackContext context)
    {
        if (colorUI != null)
            colorUI.SetActive(!colorUI.activeSelf);
    }
}
