using UnityEngine;
using UnityEngine.SceneManagement;

public class Load225 : MonoBehaviour
{
    
    
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("225");
    }
}