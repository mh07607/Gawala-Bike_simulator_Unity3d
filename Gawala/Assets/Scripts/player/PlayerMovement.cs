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
    [SerializeField] WheelCollider frontwheelcoll, backwheelcoll;
    [SerializeField] Transform frontwheel, backwheel;
    
    public int speed = 500;
    // Start is called before the first frame update
    void Start()
    {
        cc = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Movement(cc);
        backwheelcoll.motorTorque = bikespeed ;
        //frontwheelcoll.motorTorque = bikespeed;
    }

    private void GetInput() //using this as subsitute for player controller
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        

    }

    
    private void Movement(CharacterController cc)
    {
        pc = cc.GetComponent<PlayerController>();
        direction = new Vector3(0, 0, 1);
        cc.SimpleMove(direction * speed * Time.deltaTime);
    }

}
