using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Backlist : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Settings_Canvas;
    public Button set_button;
    public GameObject Othegameobj;
    // Start is called before the first frame update
    void Start()
    {
        
        set_button.onClick.AddListener(TaskOnClick);

    }

    // Update is called once per frame
    void TaskOnClick()
    {
        Settings_Canvas.SetActive(false);
        Othegameobj.SetActive(true);
    }
}

