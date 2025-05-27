using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SceneActions : MonoBehaviour
{
    public GameObject cubePrefab;
    public Transform spawnPoint;
    public AudioClip clickSound;
    public XRBaseController leftController;
    public XRBaseController rightController;

    private bool gravityEnabled = true;

    public void SpawnCube()
    {
        GameObject cube = Instantiate(cubePrefab, spawnPoint.position, Quaternion.identity);
        cube.tag = "Respawn"; // ✅ Matches overlay counter
        ProvideFeedback();
    }

    public void ToggleGravity()
    {
        gravityEnabled = !gravityEnabled;

        foreach (Rigidbody rb in FindObjectsOfType<Rigidbody>())
        {
            rb.useGravity = gravityEnabled;
        }

        // ✅ Also update global gravity for overlay detection
        Physics.gravity = gravityEnabled ? new Vector3(0, -9.81f, 0) : Vector3.zero;

        ProvideFeedback();
    }

    public void ResetScene()
    {
        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Respawn"))
        {
            Destroy(obj); // ✅ Only deletes blocks, not UI
        }
        ProvideFeedback();
    }


    private void ProvideFeedback()
    {
        // ✅ Audio click at spawn location
        AudioSource.PlayClipAtPoint(clickSound, spawnPoint.position);

        // ✅ Trigger haptics on both controllers
        if (leftController != null)
            leftController.SendHapticImpulse(0.2f, 0.1f);
        if (rightController != null)
            rightController.SendHapticImpulse(0.2f, 0.1f);
    }
}
