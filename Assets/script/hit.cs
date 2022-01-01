using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class hit : MonoBehaviour
{
    public KeyCode KeyToPress;
    public GameObject drum = null;
    public GameObject miss = null;
    public int A;
    public bool canBepress;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(A * Time.deltaTime, 0f);

        if (Input.GetKeyDown(KeyToPress))
        {
            if (canBepress)
            {
                if (drum != null)
                {
                    gameObject.SetActive(false);
                    Instantiate(drum, Vector2.zero, Quaternion.identity);
                    
                }
                    
                
            }
        }
}
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "good")
        {
            canBepress = true;
        }
        if(other.tag == "perfect")
        {
            canBepress = true;
        }
        if (other.tag == "miss")
        {
            Instantiate(miss, Vector2.zero, Quaternion.identity);
            canBepress = false;
            
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "good")
        {
            canBepress = false;
        }
        if (other.tag == "perfect")
        {
            canBepress = false;
        }
    }
}
