using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMove : MonoBehaviour
{
    public CharacterController2D characterControl;

    public float playerSpeed;
    
    private float horizontalMove;
    private bool jump;

    private bool crouch;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        float i = 0.01f;
        horizontalMove = (0.1f + i * Time.realtimeSinceStartup) * playerSpeed;
        if (Input.GetKey("space"))
        {
            jump = true;
        }

        if (Input.GetAxisRaw("Vertical") == -1f)
        {
            crouch = true;
        }
        else
        {
            crouch = false;
        }
        
    }

    private void FixedUpdate()
    {
        characterControl.Move(horizontalMove, crouch, jump);
       
            jump = false;
    }
}
