using UnityEngine;
using UnityEngine.InputSystem;

public class ToggleColorY : MonoBehaviour
{
    private Renderer rend;
    private bool isGreen = false;

    [Header("Input Action Reference")]
    public InputActionReference yButtonAction; // Assign this in Inspector

    void Start()
    {
        rend = GetComponent<Renderer>();
        if (rend != null)
        {
            rend.material.color = Color.red; // Start with red
        }

        if (yButtonAction != null)
        {
            yButtonAction.action.performed += OnYButtonPressed;
        }
    }

    private void OnEnable()
    {
        if (yButtonAction != null)
        {
            yButtonAction.action.Enable();
        }
    }

    private void OnDisable()
    {
        if (yButtonAction != null)
        {
            yButtonAction.action.Disable();
        }
    }

    private void OnYButtonPressed(InputAction.CallbackContext context)
    {
        Toggle();
    }

    public void Toggle()
    {
        if (rend != null)
        {
            isGreen = !isGreen;
            rend.material.color = isGreen ? Color.green : Color.red;
        }
    }
}
