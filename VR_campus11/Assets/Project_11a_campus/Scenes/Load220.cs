using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load220 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        HallPositionPlayer.playerPosition = new Vector3(64f, 0f, -3f);
        HallPositionPlayer.isStart = false;
        SceneManager.LoadScene("220");
    }
}
