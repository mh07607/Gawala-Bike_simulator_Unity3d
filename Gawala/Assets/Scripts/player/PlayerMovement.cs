using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    private PlayerController pc;
    private CharacterController cc;
    private Vector3 direction;
    private float horizontal, vertical;

    [SerializeField] float bikespeed = 500;
    [SerializeField] float brakespeed = 500;

    [SerializeField] WheelCollider frontwheelcoll, backwheelcoll;
    [SerializeField] Transform frontwheel, backwheel;
    [SerializeField] float maxsteerAngle = 30;
    
    // Start is called before the first frame update
    void Start()
    {
            
    }

    private void Update()
    {
        GetInput();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        //Movement(cc);


        frontwheelcoll.steerAngle = horizontal * maxsteerAngle;

        if (Input.GetKey("s"))
        {
            Debug.Log("brakes are applied");
            ApplyBrake(brakespeed);
        }
        else
        {
            ApplyBrake(0);
            backwheelcoll.motorTorque = bikespeed;
        }
    }

    void ApplyBrake(float brakespeed)
    {
        frontwheelcoll.brakeTorque = brakespeed;
        backwheelcoll.brakeTorque = brakespeed;

    }


    private void GetInput() //using this as subsitute for player controller
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        

    }

 

}
