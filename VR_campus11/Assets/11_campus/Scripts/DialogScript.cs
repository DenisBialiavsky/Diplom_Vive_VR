using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using UnityEngine;
using UnityEngine.Video;

public class DialogScript : MonoBehaviour
{
    public GameObject[] participants;
    public string AudioPatch;
    public uint StartDelay;
    public bool AutoStart = false;
    public VideoPlayer player;
    
    private int step;
    private int govorun;
    private int countParticipants;
    private AudioSource[] realParticipants;
    private AudioSource _activePlay;
    private AudioClip[] loadClip;
    private IEnumerator coroutine;

    private bool isStart;
    private bool isSound;
    private bool isFinish;
    private bool isPlay;

    // Start is called before the first frame update
    void Start()
    {
        this.countParticipants = this.participants.Length;
        this.realParticipants = new AudioSource[this.countParticipants];
        for (int i = 0; i < this.participants.Length; i++)
            this.realParticipants[i] = this.participants[i].GetComponent<AudioSource>();

        var objectes = Resources.LoadAll(this.AudioPatch, typeof(AudioClip));
        this.loadClip = new AudioClip[objectes.Length];
        for (int i = 0; i < objectes.Length; i++)
            this.loadClip[i] = (AudioClip)objectes[i];


        
        this.isStart = false;
        this.isFinish = false;
        this.isPlay = this.AutoStart ? true : false;
        this.step = 0;
        this.govorun = 0;
        this._activePlay = null;
    }

    IEnumerator nextStep(int gov, int st)
    {
        AudioClip clip = null;

        string name = "" + (gov+1) + "_" + (st+1);
        foreach (AudioClip a in this.loadClip)
            if (a.name.IndexOf(name) == 0)
                {
                    clip = a;
                    break;
                }
        bool isEmpity = true;
        if (clip != null)
        {
            isEmpity = false;
            this.realParticipants[gov].clip = clip;
            this._activePlay = this.realParticipants[gov];
            this.realParticipants[gov].Play();
            yield return new WaitForSeconds(clip.length);
            this._activePlay = null;
        }

        if (isEmpity) this.isFinish = true;
    }

    // Update is called once per frame
    IEnumerator StartDialog()
    {
        yield return new WaitForSeconds(this.StartDelay);
        while (!this.isFinish && this.isPlay)
        {
            //Debug.Log("start step " + step);
            int a = govorun, b = step;
            if (this.player != null && (a == 1 && b == 1)) this.player.Play();
            govorun++;
            if(govorun == countParticipants)
            {
                govorun = 0;
                step++;
            }
            yield return this.nextStep(a, b);
        }
        this.isStart = false;
    }

    IEnumerator UnpauseDialog()
    {
        if (this.player != null) this.player.Play();
        if (this._activePlay != null)
        {
            this._activePlay.UnPause();
            yield return new WaitForSeconds(this._activePlay.clip.length - this._activePlay.time);
            this._activePlay = null;
            this.isStart = false;
        }
    }

    void Update()
    {
        if (!this.isStart  && this.isPlay)
        {
            this.isStart = true;
            
            if (this._activePlay != null)
            {
                this.coroutine = UnpauseDialog();
                StartCoroutine(coroutine);
            }   
            else
            {
                this.coroutine = StartDialog();
                StartCoroutine(coroutine);
            }
        }
    }


    public void startDialog() {
        
        if (isFinish)
        {
            step = 0;
            isFinish = false;
        }
        this.isPlay = true;
    }

    public void stopDialog() {
        if (this._activePlay != null) this._activePlay.Pause();
        if (this.player != null) this.player.Pause();
        this.isPlay = false;
        this.isStart = false;
        if(this.coroutine != null)
            StopCoroutine(coroutine);
        this.coroutine = null;
    }
}
