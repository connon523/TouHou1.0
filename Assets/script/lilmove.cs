using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lilmove : MonoBehaviour
{
    float radian = 0;
    float perRadian = 0.05f;
    float radius = 0.1f;
    Vector3 oldpos;
    // Start is called before the first frame update
    void Start()
    {
        oldpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        radian += perRadian;

        float dy = Mathf.Cos(radian) * radius;
        transform.position = oldpos + new Vector3(0, dy, 0);    
    }
}
