using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemy2Move : MonoBehaviour
{
    private Rigidbody2D rb;

    private bool moveRight;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // triple jump every once in awhile, hopefully doesn't jump away lol
        // will shoot boomerangs
        if (moveRight) {
            rb.AddForce(new Vector2(1f, 0));
        } else {
            rb.AddForce(new Vector2(-1f, 0));
        }

    }

    void OnCollisionEnter(Collision col) {
        moveRight = !moveRight;
    }

    private void FixedUpdate()
    {
    }
}
