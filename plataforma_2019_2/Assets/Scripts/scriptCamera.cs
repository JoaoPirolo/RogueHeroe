using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptCamera : MonoBehaviour
{
    public GameObject pc;
    public float yOffset;

    // Start is called before the first frame update
    void Start()
    {
        yOffset = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = new Vector3(pc.transform.position.x,
                                  pc.transform.position.y+yOffset,
                                  -10);
        transform.position = pos;
            
    }
}
