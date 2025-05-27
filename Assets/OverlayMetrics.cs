using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class OverlayMetrics : MonoBehaviour
{
    [Header("Overlay UI")]
    public TextMeshProUGUI fpsText;
    public TextMeshProUGUI blockText;
    public TextMeshProUGUI gravityText;
    public GameObject overlayPanel;

    [Header("Input Action")]
    public InputActionReference toggleOverlayAction;

    private float deltaTime;

    void OnEnable()
    {
        if (toggleOverlayAction != null)
        {
            toggleOverlayAction.action.Enable();
            toggleOverlayAction.action.performed += ToggleOverlay;
        }
    }

    void OnDisable()
    {
        if (toggleOverlayAction != null)
        {
            toggleOverlayAction.action.performed -= ToggleOverlay;
            toggleOverlayAction.action.Disable();
        }
    }

    void Update()
    {
        // FPS + frame time
        deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;
        float fps = 1.0f / deltaTime;
        float frameTime = deltaTime * 1000f;

        if (fpsText != null)
            fpsText.text = $"FPS: {fps:0} ({frameTime:0.0} ms)";

        // Block count (tagged "Respawn")
        int blockCount = GameObject.FindGameObjectsWithTag("Respawn").Length;
        if (blockText != null)
            blockText.text = $"Blocks: {blockCount}";

        // Gravity state
        if (gravityText != null)
            gravityText.text = "Gravity: " + (Physics.gravity.y < 0 ? "ON" : "OFF");
    }

    void ToggleOverlay(InputAction.CallbackContext ctx)
    {
        if (overlayPanel != null)
        {
            overlayPanel.SetActive(!overlayPanel.activeSelf);
            Debug.Log("Overlay toggled: " + overlayPanel.activeSelf);
        }
    }
}
