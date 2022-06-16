using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load218 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        HallPositionPlayer.isStart = false;
        HallPositionPlayer.playerPosition = new Vector3(16.64f, 0f, -2.13f);
        SceneManager.LoadScene("218");
    }
}
