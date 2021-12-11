using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraController : MonoBehaviour
{

    public Transform cameraPos;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = this.transform.position;
        temp.x = temp.x + 3f;
        temp.y = 0.95f;
        temp.z = -10f;
        cameraPos.position = temp;
    }
}
