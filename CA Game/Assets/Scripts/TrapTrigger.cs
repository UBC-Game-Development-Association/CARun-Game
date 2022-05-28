using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Creates a new 2D collider when it is applied
[RequireComponent(typeof(BoxCollider2D))]

public class TrapTrigger : MonoBehaviour
{
    public GameObject player;
    public int damage;
    private PlayerHealth health;

    void Start(){

        health = player.GetComponent<PlayerHealth>();

    }

    private void Reset()
    {
        GetComponent<BoxCollider2D>().isTrigger=true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            health.removeHealth(damage);
            Debug.Log(health.getHealth());
        }
    }
}
