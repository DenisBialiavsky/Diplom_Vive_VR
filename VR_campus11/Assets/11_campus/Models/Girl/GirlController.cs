using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WomanState { Idle, Start, Moving, End, Sitting };

public class GirlController : MonoBehaviour {

	public WomanState state = WomanState.Idle;

    public Transform target;
    public Transform sittingPosition;

    public float speed;

    Animator animator;
    bool playerInActivateArea = false;
    
    void Start () {
        animator = GetComponent<Animator>();
    }
	
	void Update () {
        switch (this.state)
        {
            case WomanState.Idle:
                // animator.SetBool("isWalking", false);
                this.checkForTrigger();
                break;
            case WomanState.Start:
                animator.SetBool("isWalking", true);
                this.MoveToFinalPoint();
                this.state = WomanState.Moving;
                break;
            case WomanState.Moving:
                animator.SetBool("isWalking", true);
                this.MoveToFinalPoint();
                this.CheckForMovingEnd();
                break;
            case WomanState.End:
                animator.SetBool("isWalking", false);
                this.state = WomanState.Sitting;
                animator.SetBool("isSitting", true);
                animator.SetBool("isTyping", true);
                this.transform.position = this.sittingPosition.position;
                break;
        }
    }

    void MoveToFinalPoint ()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }

    void CheckForMovingEnd()
    {
        if (this.gameObject.transform.position == this.target.position)
        {
            this.state = WomanState.End;
        }
    }

    void checkForTrigger()
    {
        if (this.playerInActivateArea) {
            this.state = WomanState.Start;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Collider>().tag == "Player")
        {
            this.playerInActivateArea = true;
        }
    }

    //void OnTriggerExit(Collider other)
    //{
    //    if(other.GetComponent<Collider>().tag == "Player")
    //    {
    //        this.playerInActivateArea = false;
    //    }
    //}
}
