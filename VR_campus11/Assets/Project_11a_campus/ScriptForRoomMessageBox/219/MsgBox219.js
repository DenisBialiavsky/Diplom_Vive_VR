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
 if(GUI.Button (Rect (500, 300, 500, 80), "Вы находитесь в аудитории №219\n\n[Нажмите сюда чтобы закрыть!]")) {
 bool = false;
 Destroy(gameObject);

 }
 }

 }