using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public Transform cameraTransform; // Drag the camera here in the Inspector
    public float mouseSensitivity = 100f; // Adjust for desired speed

    private float xRotation = 0f;

    void Start()
    {
        // Lock the cursor for better control
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Get mouse input
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Rotate the camera vertically (up and down)
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // Limit vertical rotation
        cameraTransform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // Rotate the player horizontally (left and right)
        transform.Rotate(Vector3.up * mouseX);
    }
}
