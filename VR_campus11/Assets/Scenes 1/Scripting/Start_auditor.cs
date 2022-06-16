using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Start_auditor : MonoBehaviour
{
    public string SceneName;
    public GameObject Wall_Door;
    // Start is called before the first frame update
    void Start()
    {

        SceneManager.LoadScene(SceneName);
    }

    private void Update()
    {
        SceneManager.LoadScene(SceneName);
    }

    public void Play_Game()
    {
        SceneManager.LoadScene(SceneName);
    }
}
