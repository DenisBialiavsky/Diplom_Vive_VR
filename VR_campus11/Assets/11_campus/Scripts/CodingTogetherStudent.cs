using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodingTogetherStudent : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject player;
    public DialogScript script;
    private bool isEnter;
    private bool isPlay = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isEnter = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isEnter = false;
        }
    }

    void OnGUI()
    {

    }

    void Update()
    {
        if(isEnter && Input.GetKeyDown(KeyCode.F))
        {
            isPlay = !isPlay;
            if(isPlay) script.startDialog();
            else script.stopDialog();
        }
    }

}