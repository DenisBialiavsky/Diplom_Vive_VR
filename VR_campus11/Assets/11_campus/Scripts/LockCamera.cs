using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCamera : MonoBehaviour
{
    public GameObject ObjectToSetAktivitiFalse;
    public Camera camera;
    public Vector3 cameraPosition = new Vector3(0, 0, 0);
    public Vector3 cameraRotation = new Vector3(0, 0, 0);
    public bool isMouseLock = true;

    private bool isEnter = false;
    private bool isLock = false;
    private Transform lastPArentCamera;
    private Vector3 lastPosition;
    private Quaternion lastRotation;


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

    void lockCamera()
    {
        if (ObjectToSetAktivitiFalse != null) ObjectToSetAktivitiFalse.SetActive(false);

        lastPArentCamera = camera.transform.parent;
        lastPosition = camera.transform.localPosition;
        lastRotation = camera.transform.localRotation;

        camera.transform.parent = this.transform;
        camera.transform.localPosition = cameraPosition;
        camera.transform.localRotation = Quaternion.Euler(cameraRotation);

        if (isMouseLock) UnityEngine.Screen.lockCursor = false;
    }

    void unlockCamera()
    {
        camera.transform.parent = lastPArentCamera;
        camera.transform.localPosition = lastPosition;
        camera.transform.localRotation = lastRotation;
        if (ObjectToSetAktivitiFalse != null) ObjectToSetAktivitiFalse.SetActive(true);


        if(isMouseLock) UnityEngine.Screen.lockCursor = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isEnter && Input.GetKeyDown(KeyCode.F))
        {
            isLock = !isLock;
            if (isLock) lockCamera();
            else unlockCamera();
        }
    }
}
