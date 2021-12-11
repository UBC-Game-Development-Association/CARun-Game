using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSpawner : MonoBehaviour
{
    
    public GameObject[] objects;
    private int setNum;
    public GameObject player;
    private List<List<GameObject>> obstacleSets;
    
    // Start is called before the first frame update
    void Start()
    {
        obstacleSets = new List<List<GameObject>>();
        setNum = 0;
        SpawnSet();
    }

    // Update is called once per frame
    void Update()
    {
        checkZone(player.transform.position.x);
    }

    public void checkZone(float xPos)
    {
        if (xPos > (setNum * 38.1f) - 20)
        {
            SpawnSet();

        }
    }
    private void SpawnSet()
    {
        Vector3 spawnVector;
        int rand = 0;
        List<GameObject> thisSet = new List<GameObject>();
        for (int i = 0; i < 15; i++)
        {

            if (setNum > 1)
            {
                rand = Random.Range(0, 7);
            }

            spawnVector = new Vector3((i * 2.54f) + (setNum * 38.1f), -4.14f, 0f);
            thisSet.Add(Instantiate(objects[0], spawnVector, Quaternion.identity));
            
            if (rand == 1)
            {
                spawnVector = new Vector3((i * 2.54f) + (setNum * 38.1f), -1.92f, 0f);
                thisSet.Add(Instantiate(objects[1], spawnVector, Quaternion.identity));
            }
            else if (rand == 2)
            {
                spawnVector = new Vector3((i * 2.54f) + (setNum * 38.1f), -1.92f, 0f);
                thisSet.Add(Instantiate(objects[2], spawnVector, Quaternion.identity));
            }
        }

        obstacleSets.Add(thisSet);
        
        if (setNum > 2)
        {
            removeOldSet();
        }
        
        setNum++;
    }

    private void removeOldSet()
    {
        List<GameObject> toRemove = obstacleSets[0];
        obstacleSets.RemoveAt(0);

        foreach (GameObject obstacle in toRemove)
        {
            Destroy(obstacle);
        }
    }
}
