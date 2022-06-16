﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatingPhysicsMsg : MonoBehaviour
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
            GUI.TextArea(new Rect((Screen.width / 2 - 250), (Screen.height / 2 - 100), 400, 80), "Студент создаёт физику объекта в Unity. Пока только тренируется, создавая катящийся по наклонной поверхности куб.");

        }

    }

}