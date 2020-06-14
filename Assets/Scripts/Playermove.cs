using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{

    Vector3 moveVector = Vector3.zero;
    CharacterController charecterController;

    public float movespeed;
    public float jumpspeed;
    public float gravity;


    // Start is called before the first frame update
    void Start()
    {
        charecterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        moveVector.x = Input.GetAxis("Horizontal") * movespeed;
        moveVector.z = Input.GetAxis("Vertical") * movespeed;

        if(charecterController.isGrounded && Input.GetButton("Jump"))
                moveVector.y = jumpspeed;
            
        moveVector.y -= gravity * Time.deltaTime;     
        charecterController.Move(moveVector * Time.deltaTime);
    }

}
