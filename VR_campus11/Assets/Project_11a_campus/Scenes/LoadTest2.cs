using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadTest2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("GameTest");
        SceneManager.LoadScene("GameTest");
    }
}
