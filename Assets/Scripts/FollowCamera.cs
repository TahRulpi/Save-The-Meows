using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class FollowCamera : MonoBehaviour
{
    public Transform target;
    public float distance = 1.5f;
    public float height = 3f;
    public float smoothness = 9.5f;

    public float mouseSensitivity = 100f;
    private float rotationY = 0f;
    private float rotationX = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // for cursor lock
    }

    void LateUpdate()
    {
       
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime; //for Horizontal=lef/right 
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime; // for Vertical=up/down

        // Accumulate rotations for smooth control
        rotationY += mouseX;
        rotationX -= mouseY; // Add instead of subtract for natural upward movement

        // Limit vertical rotation to prevent extreme camera angles
        rotationX = Mathf.Clamp(rotationX, -45f, 45f);

        // Applying the rotations
        Quaternion rotation = Quaternion.Euler(rotationX, rotationY, 0);

        // Camera position and rotation
        Vector3 desiredPosition = target.position - rotation * Vector3.forward * distance;
        desiredPosition += Vector3.up * height;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothness * Time.deltaTime);

        // Make the camera look at the player
        transform.LookAt(target);
    }
}
