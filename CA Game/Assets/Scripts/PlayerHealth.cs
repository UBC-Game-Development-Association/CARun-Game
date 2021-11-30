using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int healthVal;
    public bool alive;
    public int max;

    public void setHealth(int val){
        
        healthVal = val;

    }

    public void removeHealth(int val){
        healthVal = healthVal - val;
        if (healthVal < 0){
            alive = false;
        }

    }

    public void addHealth(int val){
        healthVal = healthVal + val;
        if (healthVal > max){
            healthVal = max;
        }
    }

}
