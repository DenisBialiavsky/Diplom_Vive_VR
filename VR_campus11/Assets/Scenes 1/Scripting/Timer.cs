using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public float t = 60;
    public float tmin = 0;
    public GameObject panel;
    public Text mytext;
    public GameObject GOpanel;

    // Update is called once per frame
    void Update()
    {
        mytext.text = " Осталось " + t + " сек. ";
        t = t - Time.deltaTime;

        if (t <= 0)
        {
            panel.SetActive(false);
            GOpanel.SetActive(true);

        }

        if (t <= 20)
        {
            mytext.color = Color.red;
        }
    }
}
