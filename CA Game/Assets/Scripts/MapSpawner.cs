using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSpawner : MonoBehaviour
{
    
    public GameObject[] objects;
    private int setNum;
    
    // Start is called before the first frame update
    void Start()
    {
        setNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnSet()
    {
        int rand = Random.Range(0, 7);
        for (int i = 0; i < 15; i++)
        {
            
        }
    }

    private void deleteSet()
    {
        
    }
}
