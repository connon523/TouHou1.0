using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossmove : MonoBehaviour
{
    float radian = 0;
    float perRadian = 0.2f;
    float radius = 3f;
    Vector3 oldpos;
    // Start is called before the first frame update
    void Start()
    {
        oldpos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        radian += perRadian;

        float dy = Mathf.Cos(radian) * radius;
        transform.localPosition = oldpos + new Vector3(0, dy, 0);
    }
}
