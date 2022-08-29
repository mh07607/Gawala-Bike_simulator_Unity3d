using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spherecontroller : MonoBehaviour
{
    Rigidbody rb;

    Vector3 eulerAngleVelocity;
    float horizontal, vertical;

    [SerializeField] float speed = 50;
    [SerializeField] float steerangle = 30;
    // Start is called before the first frame update
    void Start()
    {
        
        rb = gameObject.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        eulerAngleVelocity = new Vector3(0, 0, horizontal*steerangle);
        rb.AddForce(new Vector3 (horizontal, 0, 1)*speed);

        //Quaternion deltaRotation = Quaternion.Euler(eulerAngleVelocity * Time.fixedDeltaTime);
        //rb.MoveRotation(rb.rotation * deltaRotation);
        //rb.AddTorque(Vector3.forward * horizontal * steerangle);

    }
}
