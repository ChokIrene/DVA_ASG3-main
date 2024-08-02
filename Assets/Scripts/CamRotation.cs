using UnityEngine;
using UnityEngine.EventSystems;

public class CamRotation : MonoBehaviour
{
    public float sensitivity = 2.0f;  // Sensitivity of mouse movement
    public float zoomSpeed = 10.0f;   // Speed of zooming in and out
    public float minZoom = 10.0f;     // Minimum zoom distance
    public float maxZoom = 100.0f;    // Maximum zoom distance

    private float yaw = 0.0f;
    private float pitch = 0.0f;
    private Camera camera;

    void Start()
    {
        camera = GetComponent<Camera>();  // Get the camera component
        Cursor.visible = false;
    }

    void Update()
    {
        // Check if the mouse is over a UI element
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            // Rotate the camera based on mouse movement
            yaw += sensitivity * Input.GetAxis("Mouse X");
            pitch -= sensitivity * Input.GetAxis("Mouse Y");

            // Clamp the pitch to avoid extreme looking up or down
            pitch = Mathf.Clamp(pitch, -90f, 90f);

            // Apply rotation to the camera
            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

            // Handle zoom functionality
            float scroll = Input.GetAxis("Mouse ScrollWheel");
            camera.fieldOfView = Mathf.Clamp(camera.fieldOfView - scroll * zoomSpeed, minZoom, maxZoom);
        }
    }
}