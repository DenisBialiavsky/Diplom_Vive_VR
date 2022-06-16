using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oscillation : MonoBehaviour
{
    public float AMPLITUDE = 0.005f;
    public int n1 = 1;
    public int n2 = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        n1 +=1; // счетчик кадров
        if (n1 == n2) //при достижении определенного количества кадров
        {
            AMPLITUDE *= -1; //меняется направление движения 
            n1 = 0; // обнуляется счетчик
        }
        transform.Translate(new Vector3(0,AMPLITUDE,0));
       
    }
}