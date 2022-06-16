using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Video : MonoBehaviour {

    public GameObject monitorObject;
    public VideoPlayer player;
    public Button stop;
    public Slider slider;

    private bool isEnter;
    private bool isStart = false;
    private bool isStop = true;
    

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().tag == "Player")
        {
            isEnter = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Collider>().tag == "Player")
        {
            isEnter = false;
        }
    }

    void Start()
    {
        if(stop!=null) stop.onClick.AddListener(delegate { stopStartPlay(); });
    }

    public void setTimeBySlider()
    {
        if (slider != null && player != null)
        {
            double setTime = (slider.value * player.clip.length);
            double currentTime = player.time;
            if(Math.Abs(setTime - currentTime) > 2.0)
            {
                player.time = setTime;
                Debug.Log("STOXYEB");
            }
        }
            
    }

    void stopStartPlay()
    {
        if(player != null)
        {
            isStop = !isStop;
            if (isStop) player.Pause();
            else player.Play();
        }
        
    }

    void Update()
    {
        if(isEnter && Input.GetKeyDown(KeyCode.F))
        {
            isStart = !isStart;
            this.monitorObject.SetActive(isStart);
            isStop = isStart;
            stopStartPlay();
        }

        if(slider!= null && player!=null && isStart && !isStop)
        {
            slider.value = (float)(player.time / player.clip.length);
        }
    }
}
