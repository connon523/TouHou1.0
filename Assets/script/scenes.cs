using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scenes1timer : MonoBehaviour
{
    float time_f;
    int timer_1;
    public GameObject pos;

    // Start is called before the first frame update
    void Start()
    {
        Hide();
    }

    // Update is called once per frame
    void Update()
    {
        time_f = Time.time;
        timer_1 = Mathf.FloorToInt(time_f);
        Debug.Log(timer_1);
        if (timer_1 == 60)
        {
            Show();
        }
    }
    void Show()
    {
        pos.SetActive(true);
    }
    void Hide()
    {
        pos.SetActive(false);
    }

}
