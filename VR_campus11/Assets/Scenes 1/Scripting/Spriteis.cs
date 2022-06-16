using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spriteis : MonoBehaviour
{
    public Sprite newSprite;

    public void OnClick()
    {
        GetComponent<Image>().sprite = newSprite;
    }
}
