using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallPositionPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    public static Vector3 playerPosition;
    public static bool isStart = true;

    // Start is called before the first frame update
    void Start()
    {
        if (!isStart)
        {
            player.transform.position = playerPosition;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
