using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nomouse : MonoBehaviour { 
bool isLocked;
 // Use this for initialization
 void Start () {
    SetCursorLock(true);
}

void SetCursorLock(bool isLocked)
{
    this.isLocked = isLocked;
    //Screen.lockCursor = isLocked;
    Cursor.visible = !isLocked;
}
// Update is called once per frame
void Update()
{
    if (Input.GetKeyDown(KeyCode.Tab))
        SetCursorLock(!isLocked);
}
}