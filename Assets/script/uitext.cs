using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uitext : MonoBehaviour
{
    static public  GameObject pic;
    static public  bool pics;
    
    // Start is called before the first frame update
    void Start()
    {
        pics = false;
        pic.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        pic.SetActive(pics);
        if (pics==true)
        {
            Invoke("picfalse", 1f);
        }
    }
    void picfalse()
    {
        pics = false;
        pic.SetActive(false);
    }
}
