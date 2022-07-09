using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Creates a new 2D collider when it is applied
[RequireComponent(typeof(BoxCollider2D))]

public class TrapTrigger : MonoBehaviour
{
    public GameObject player;
    public int damage;
    public PlayerHealth health;
    public bool active = true;
    public float secondsToActivate = 0;
    void Start(){

        health = player.GetComponent<PlayerHealth>();

    }

    void Update()
    {
        secondsToActivate = secondsToActivate - 1*Time.deltaTime;
        if (secondsToActivate < 0)
        {
            active = true;
        }
    }
    
    private void Reset()
    {
        GetComponent<BoxCollider2D>().isTrigger=true;
    }

    public void activateTrap()
    {
        active = true;
    }

    public void deactivateTrap()
    {
        active = false;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Player" && active)
        {
            health.removeHealth(damage);
            Debug.Log(health.getHealth());
        }
    }
}
