using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[AddComponentMenu("My components/Telep")]
public class Telep : MonoBehaviour
{
    [Header("Индекс сцены")]
    public int sceneIndex;
    private void OnTriggerEnter(Collider myCollider)
    {
        if (myCollider.tag == ("Player"))
        {
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
