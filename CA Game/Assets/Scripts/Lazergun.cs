using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazergun : MonoBehaviour
{
    public GameObject beam;
    public GameObject curPlayer;
    public Transform gun;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void triggerTrap()
    {
        //Spawn a lazer with same Y/z and -9.5 from x
        Vector2 newPos = new Vector2(gun.position.x - 9.5f, gun.position.y);
        GameObject lazer = Instantiate(beam, newPos, Quaternion.identity);
        TrapTrigger trigger = lazer.GetComponent<TrapTrigger>();
        trigger.player = curPlayer;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            triggerTrap();
        }
    }
}
