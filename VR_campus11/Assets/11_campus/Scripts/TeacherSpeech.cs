using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeacherSpeech : MonoBehaviour {

    public AudioSource audioSource;    

    void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Collider>().tag == "Player")
        {
            audioSource.Play();
        }
        
        
    }

    //void OnTriggerExit(Collider other)
    //{
    //    audioSource.Stop();
    //}
}
