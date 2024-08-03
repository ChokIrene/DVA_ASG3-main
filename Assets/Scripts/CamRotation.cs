using UnityEngine;
using UnityEngine.EventSystems;

public class CamRotation : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Adjusted speed of camera movement
    public float zoomSpeed = 15.0f; // Speed of zooming in and out
    public float minZoom = 10.0f;   // Minimum zoom distance (field of view)
    public float maxZoom = 100.0f;  // Maximum zoom distance (field of view)
    public float rotationSensitivity = 0.4f; // Sensitivity of mouse rotation

    private Camera camera;
    private float yaw = 0.0f;
    private float pitch = 0.0f;

    void Start()
    {
        camera = GetComponent<Camera>(); // Get the camera component
        // Ensure cursor is always unlocked and visible
        Cursor.visible = true;
    }

    void Update()
    {
        // Mouse input for rotation (only if not over a UI element)
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            yaw += Input.GetAxis("Mouse X") * rotationSensitivity;
            pitch -= Input.GetAxis("Mouse Y") * rotationSensitivity;
            pitch = Mathf.Clamp(pitch, -90f, 90f);

            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        }

        // Zoom functionality
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        camera.fieldOfView = Mathf.Clamp(camera.fieldOfView - scroll * zoomSpeed, minZoom, maxZoom);

        // Camera movement using WASD keys and arrow keys
        float moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float moveY = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float moveZ = 0;

        if (Input.GetKey(KeyCode.Q)) moveZ -= moveSpeed * Time.deltaTime; // Move down
        if (Input.GetKey(KeyCode.E)) moveZ += moveSpeed * Time.deltaTime; // Move up

        transform.Translate(moveX, moveZ, moveY);
    }
}