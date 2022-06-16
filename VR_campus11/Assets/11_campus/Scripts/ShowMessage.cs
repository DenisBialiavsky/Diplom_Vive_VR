using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMessage : MonoBehaviour
{
    public string OnGUIMessage = null;
    public GUIStyle style;


    private bool isEnter;

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
        if (isEnter)
        {
            GUI.TextArea(new Rect(.5f * Screen.width, .9f * Screen.height, 20, 20), OnGUIMessage, style);
        }

    }

}
