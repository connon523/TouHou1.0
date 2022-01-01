using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 和風camera : MonoBehaviour
{
    private float mSpeed = 6.0F;
    void Start()
    {

    }


    void FixedUpdate()
    {
        
        transform.Translate(Vector3.right * Time.deltaTime * mSpeed);
       
       
    }
}
