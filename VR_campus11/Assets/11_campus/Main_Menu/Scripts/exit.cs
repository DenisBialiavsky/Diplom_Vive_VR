using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.Experimental.UIElements;
using UnityEngine.Experimental;
using System;

public class exit : MonoBehaviour {

    public UnityEngine.UI.Button exitButton; 

    void Start()
    {
        exitButton.onClick.AddListener(TaskOnClick);
    }

    private void TaskOnClick()
    {
        Application.Quit();
    }

  
}
