using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class SceneManagerPrj : MonoBehaviour {

    public static SceneManagerPrj Instance{ set; get; }

    private void Awake()
    {
        Instance = this;
        Load("Menu");
        DontDestroyOnLoad(gameObject);
    }

    public void Load (string sceneName)
    {
        //if (!SceneManager.GetSceneByName(sceneName).isLoaded)
            //SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
            SceneManager.LoadScene(sceneName);
    }

    public void Unload (string sceneName)
    {
        if (SceneManager.GetSceneByName(sceneName).isLoaded)
            SceneManager.UnloadSceneAsync(sceneName);
    }



}
