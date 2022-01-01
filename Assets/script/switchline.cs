using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchline : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 target = new Vector3(transform.position.x, -15, transform.position.z);
            gameObject.transform.position = target;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 target = new Vector3(transform.position.x, -20, transform.position.z);
            gameObject.transform.position = target;
        }
    }
}
