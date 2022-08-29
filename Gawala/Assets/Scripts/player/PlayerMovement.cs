using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    //private PlayerController pc;
    private CharacterController cc;
    private Vector3 direction;
    private float horizontal, vertical;
    private Rigidbody rb;

    [SerializeField] private Rigidbody balancingcubeL, balancingcubeR;

    [SerializeField] float bikespeed = 500;
    [SerializeField] float brakespeed = 500;
    [SerializeField] float balanceforce = 500000;

    [SerializeField] WheelCollider frontwheelcoll, backwheelcoll;
    [SerializeField] Transform frontwheel, backwheel;
    [SerializeField] float maxsteerAngle = 30;
    
    // Start is called before the first frame update
    void Start()
    {
        rb =   gameObject.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        GetInput();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        //Movement(cc);

        /*if (Time.realtimeSinceStartup < 5)
        {
            rb.freezeRotation = true;
        }
        else
        {
            rb.freezeRotation = false;
            //rb.AddTorque(transform.forward * balanceforce * Time.deltaTime);
        }*/

        if (Input.GetKey(KeyCode.E))
        {
            rb.AddTorque(transform.forward * balanceforce );
            Debug.Log("Torque is applied");
        }
        if (Input.GetKey(KeyCode.Q))
        {
            rb.AddTorque(transform.forward * -balanceforce );
            Debug.Log("Torque is applied");
        }

        frontwheelcoll.steerAngle = horizontal * maxsteerAngle;
    
        if (Input.GetKey("s"))
        {
            ApplyBrake(brakespeed);
        }
        else
        {
            ApplyBrake(0);
            backwheelcoll.motorTorque = bikespeed;
        }

/*        if (Input.GetKey(KeyCode.Q))
        {
            balancingcubeL.AddTorque(new Vector3(0, 0, -balanceforce));
        }
        if (Input.GetKey(KeyCode.E))
        {
            balancingcubeL.AddTorque(new Vector3(0, 0, -balanceforce));
        }*/
    }

    void ApplyBrake(float brakespeed)
    {
        frontwheelcoll.brakeTorque = brakespeed;
        //backwheelcoll.brakeTorque = brakespeed;

    }

    
    void GetInput() //using this as subsitute for player controller
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        

    }

 

}
