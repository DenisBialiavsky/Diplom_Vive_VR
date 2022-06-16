using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class studia_216 : MonoBehaviour
{
    // Start is called before the first frame update
    [System.Obsolete]
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MySwitchScenes(string MyScene2Load)
    {
        SceneManager.LoadScene("Hall");
    }
}

