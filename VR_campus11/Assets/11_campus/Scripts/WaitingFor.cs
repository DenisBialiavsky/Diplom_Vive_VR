using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitingFor : MonoBehaviour
{
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
            GUI.TextArea(new Rect((Screen.width / 2 - 250), (Screen.height / 2 - 100), 400, 80), "У студентов во время практических работ нередко возникают вопросы. Не нужно стесняться подходить к преподавателю - он всегда готов объяснить вам подробности материала и помочь в исправлении ошибок");

        }

    }

}
