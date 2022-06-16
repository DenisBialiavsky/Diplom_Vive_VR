using UnityEngine;
using System.Collections;

public class MsgGirl : MonoBehaviour
{


    public GameObject player;
    private bool logic;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            logic = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            logic = false;
        }
    }

    void OnGUI()
    {
        if (logic == true)
        {
            GUI.TextArea(new Rect((Screen.width / 2 - 250), (Screen.height / 2 - 100), 400, 80), "Происходит построение диаграммы базы данных.");

        }

    }

}