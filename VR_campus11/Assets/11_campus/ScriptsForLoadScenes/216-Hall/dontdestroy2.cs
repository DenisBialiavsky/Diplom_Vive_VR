using UnityEngine;
using System.Collections;

public class dontdestroy2 : MonoBehaviour
{
    public static Transform playerTransform;
    void Awake()
    {
        if (playerTransform = null)
        {
            Destroy(gameObject);
            return;
        }


        GameObject.DontDestroyOnLoad(transform.root.gameObject);
        playerTransform = transform;
    }
}