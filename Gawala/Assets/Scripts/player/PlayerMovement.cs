using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    private PlayerController pc;
    private CharacterController cc;
    private Vector3 direction;
    public int speed = 500;
    // Start is called before the first frame update
    void Start()
    {
        cc = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement(cc);
    }

    private void Movement(CharacterController cc)
    {
        pc = cc.GetComponent<PlayerController>();
        direction = new Vector3(0, 0, 1);
        cc.SimpleMove(direction * speed * Time.deltaTime);
    }

}
