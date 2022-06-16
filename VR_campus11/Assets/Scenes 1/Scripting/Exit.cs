using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{
    public Button exit_app;
    public Button no;
    public Button yes;

    public GameObject No;
    public GameObject Yes;

    // Start is called before the first frame update
    void Start()
    {
        
        No.SetActive(false);
        Yes.SetActive(false);
        exit_app.onClick.AddListener(TaskOnClick);

      
    }

    void TaskOnClick()
    {
        No.SetActive(true);
        Yes.SetActive(true);

        no.onClick.AddListener(Return);
        yes.onClick.AddListener(Exit_app);

    }

    void Return()
    {
        No.SetActive(false);
        Yes.SetActive(false);
    }

    void Exit_app()
    {
        Application.Quit();
    }
    // Update is called once per frame
    
}
