using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public CharacterController characterController;
    public float speed = 12f;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x * Time.deltaTime + transform.forward * z * Time.deltaTime;

        if (characterController.isGrounded == false)
        {
            //Add our gravity Vecotr
            move += Physics.gravity * Time.deltaTime;
        }
        if (characterController.isGrounded == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                characterController.Move(new Vector3(0, 5, 0));
            }
        }

        characterController.Move(move * speed);

    }
}
