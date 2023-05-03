using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float mouseSensitivity = 100f;

    public Transform playerBody;

    float xRotation = 0f;

    float yRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {


        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        xRotation -= mouseX;

        yRotation -= mouseY;
        yRotation = Mathf.Clamp(yRotation, -90, 90);

        print(xRotation);

        transform.localEulerAngles = new Vector3(yRotation, 0, 0);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
