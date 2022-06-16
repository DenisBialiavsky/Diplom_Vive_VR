using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Closeis : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Settings_Canvas;
    public Button Closei;
    // Start is called before the first frame update
    void Start()
    {

        Closei.onClick.AddListener(TaskOnClick);

    }

    // Update is called once per frame
    void TaskOnClick()
    {
        Settings_Canvas.SetActive(false);
    }
}
