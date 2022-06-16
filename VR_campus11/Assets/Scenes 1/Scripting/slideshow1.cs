using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class slideshow1 : MonoBehaviour
{

    // var imageArray : Texture[];
    // var currentImage : int;
    // var imageRect : Rect;
    // var buttonRect : Rect;

    public Texture[] imageArray;
    private int currentImage;
    //private Rect imageRect;
    //private Rect buttonRect;



    void OnGUI()
    {

        int w = Screen.width, h = Screen.height;

        //Rect imageRect = new Rect (0, 0, w, h * 2 / 100);
        Rect imageRect = new Rect(0, 0, Screen.width, Screen.height);
        Rect buttonRect = new Rect(0, Screen.height - Screen.height / 10, Screen.width, Screen.height / 10);


        // GUI.Label(guiRect, imageArray[currentImage]);
        GUI.Label(imageRect, imageArray[currentImage]);

        if (GUI.Button(buttonRect, "Next"))
            currentImage++;

        if (currentImage >= imageArray.Length)
            currentImage = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        currentImage = 0;
        // imageRect = Rect(0, 0, Screen.width, Screen.height);
        // buttonRect = Rect(0, Screen.height - Screen.height / 10, Screen.width, Screen.height / 10);
    }

    // Update is called once per frame
    void Update()
    {

    }
}