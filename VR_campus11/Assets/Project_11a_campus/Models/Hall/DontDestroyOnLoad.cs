using UnityEngine;
using System.Collections;


public class DontDestroyOnLoad : MonoBehaviour
{

    private static DontDestroyOnLoad instance;

    void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
}