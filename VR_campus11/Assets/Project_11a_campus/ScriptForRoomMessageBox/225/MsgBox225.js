#pragma strict

var player : GameObject;
 private var bool : boolean;

 function OnTriggerEnter(other : Collider) {
 if(other.tag == "Player") {
 bool = true;
 }
 }

 function OnGUI(){
 if(bool == true) {
 if(GUI.Button (Rect (500, 300, 500, 80), "Ты находишься в аудитории №225\nКакое-то описание аудитории и много какого-то текста для прочтения\n\n[Нажми сюда чтобы закрыть!]")) {
 bool = false;
 Destroy(gameObject);

 }
 }

 }