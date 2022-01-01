using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class hit : MonoBehaviour
{
    public KeyCode KeyToPress;
    public GameObject drum = null;
    public GameObject miss = null;
    public GameObject[] text = null;
    
    public int A;
    public int B;
    public bool canBepress;
    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position -= new Vector3(A * Time.deltaTime, 0f);
        
        if (Input.GetKeyDown(KeyToPress))
        {
            if (canBepress)
            {
                if (B == 0)
                {
                    score.scores += 100;
                    if (drum != null)
                    {
                        
                        gameObject.SetActive(false);
                        Instantiate(drum, Vector2.zero, Quaternion.identity);
                        Instantiate(text[0], transform.position, Quaternion.identity);

                    }
                }
                if (B == 1)
                {
                    score.scores += 300;
                    if (drum != null)
                    {
                       
                        gameObject.SetActive(false);
                        Instantiate(drum, Vector2.zero, Quaternion.identity);
                        Instantiate(text[1], transform.position, Quaternion.identity);
                    }
                }
                
                    
                
            }
        }
}
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "good")
        {
            canBepress = true;
            B = 0;
            

        }
        if(other.tag == "perfect")
        {
            canBepress = true;
            B = 1;
            
        }
        if (other.tag == "miss")
        {
            Instantiate(miss, Vector2.zero, Quaternion.identity);
            Instantiate(text[2], transform.position, Quaternion.identity);

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
