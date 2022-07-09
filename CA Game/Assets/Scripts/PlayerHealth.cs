using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private int healthVal;
    public GameObject[] hearts;
    public bool alive;
    public int max;

    private void Start() // Player stars with max (15) health
    {
        healthVal = max;
    }
    public void setHealth(int val){
        
        healthVal = val;

    }
    
    public int getHealth(){
        return healthVal;
    }

    //for removing health - enemies/obstacles
    public void removeHealth(int val){
        healthVal = healthVal - val;
        if (healthVal < 0){
            alive = false;
        }
    }

    //adding health - future healing and power-ups
    public void addHealth(int val){
        healthVal = healthVal + val;
        if (healthVal > max){
            healthVal = max;
        }
    }

    private void Update() //For 3-hearts health system
    {
        if (healthVal < max)
        {
            Destroy(hearts[2].gameObject);
        }
        if (healthVal < 10)
        {
            Destroy(hearts[1].gameObject);
        }
        if (healthVal < 5)
        {
            Destroy(hearts[0].gameObject);
        }
    }

    public void DamageButton(int d) // instant damage button to test the healthbar for now
    {
        healthVal -= d;
        Debug.Log(healthVal);
    }
}
