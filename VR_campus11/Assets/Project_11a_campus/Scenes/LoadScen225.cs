using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScen225 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        HallPositionPlayer.playerPosition = new Vector3(13.817f, 0f, -4.7f);
        HallPositionPlayer.isStart = false;
        SceneManager.LoadScene("225");
    }
}
