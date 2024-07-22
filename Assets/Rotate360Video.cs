using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate360Video : MonoBehaviour
{
    public float rotationSpeed = 10f; // Adjust the speed of rotation as needed

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); // Example: Use input to rotate
        float verticalInput = Input.GetAxis("Vertical");

        // Rotate the GameObject holding the video player
        transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);
        transform.Rotate(Vector3.right, verticalInput * rotationSpeed * Time.deltaTime);
    }
}