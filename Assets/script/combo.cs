using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class combo : MonoBehaviour
{
    public Text ct;                  //combo text
    public static int cc;                         //combo count
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        ct.text = cc.ToString();
    }
    
}
