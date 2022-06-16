using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadTrigger : MonoBehaviour {

    public string loadName;
    public string unloadName;

    private void OnTriggerEnter (Collider col)
    {
        Debug.Log(loadName);
        if(loadName != "Hall")
        {
           // SceneManagerPrj.Instance.Load(loadName);
            SceneManager.LoadScene(loadName);
        }

        if(unloadName != "Hall")
        {
            StartCoroutine("UnloadScene");
        }
    }

    IEnumerator UnloadScene()
    {
        yield return new WaitForSeconds(.10f);
        SceneManagerPrj.Instance.Unload(unloadName);
    }

}
