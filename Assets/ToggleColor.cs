using UnityEngine;
using UnityEngine.InputSystem;

public class ToggleColor : MonoBehaviour
{
    private Renderer rend;
    private bool isGreen = false;

    [Header("Input Action")]
    public InputActionReference yButtonAction; // Link this in Inspector

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = Color.red;

        if (yButtonAction != null)
            yButtonAction.action.performed += OnYButtonPressed;
    }

    private void OnEnable()
    {
        if (yButtonAction != null)
            yButtonAction.action.Enable();
    }

    private void OnDisable()
    {
        if (yButtonAction != null)
            yButtonAction.action.Disable();
    }

    private void OnYButtonPressed(InputAction.CallbackContext context)
    {
        Toggle();
    }

    public void Toggle()
    {
        isGreen = !isGreen;
        rend.material.color = isGreen ? Color.green : Color.red;
    }
}
