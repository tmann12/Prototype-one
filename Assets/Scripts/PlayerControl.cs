using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Camera firstPersonCamera;
    public Camera thirdPersonCamera;
    // Start is called before the first frame update


    void Start()
    {
        firstPersonCamera.enabled = isFirstPerson;
        thirdPersonCamera.enabled = !isFirstPerson;
    }
         private float speed = 20.0f;
         private float turnspeed = 45.0f;
         private float horizontalInput;
         private float forwardInput;
         private bool isFirstPerson = true;
    // Update is called once per frame 
    void Update()
    {
        HandleCameraSwitch();
         horizontalInput = Input.GetAxis("Horizontal");
         forwardInput = Input.GetAxis("Vertical");
         // Moves the car forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Rotates the car based on Horizontal input 
        transform.Rotate(Vector3.up * Time.deltaTime * turnspeed * horizontalInput); 
    }

    void HandleCameraSwitch()
    {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                isFirstPerson =!isFirstPerson;

                firstPersonCamera.enabled = isFirstPerson;
                thirdPersonCamera.enabled = !isFirstPerson;

            }


    }
}
