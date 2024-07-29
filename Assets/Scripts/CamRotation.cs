using UnityEngine;

public class CamRotation : MonoBehaviour
{
    public float sensitivity = 2.0f;  // Sensitivity of mouse movement

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    void Start()
    {
        
    }

    void Update()
    {
        // Rotate the camera based on mouse movement
        yaw += sensitivity * Input.GetAxis("Mouse X");
        pitch -= sensitivity * Input.GetAxis("Mouse Y");

        // Clamp the pitch to avoid extreme looking up or down
        pitch = Mathf.Clamp(pitch, -90f, 90f);

        // Apply rotation to the camera
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }

    void StartRotation()
    {
        // Rotate the camera based on mouse movement
        yaw += sensitivity * Input.GetAxis("Mouse X");
        pitch -= sensitivity * Input.GetAxis("Mouse Y");

        // Clamp the pitch to avoid extreme looking up or down
        pitch = Mathf.Clamp(pitch, -90f, 90f);

        // Apply rotation to the camera
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
}
