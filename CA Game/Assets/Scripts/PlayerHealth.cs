using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private int healthVal;
    public bool alive;
    public int max;

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

}
