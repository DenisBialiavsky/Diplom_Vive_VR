using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Start_game : MonoBehaviour
{
    public string SceneName;
    public Button playbutton;
    // Start is called before the first frame update
    void Start()
    {
        playbutton.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        SceneManager.LoadScene(SceneName);
    }
}
