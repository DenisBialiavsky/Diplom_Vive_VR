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
 if(GUI.Button (Rect (500, 300, 500, 80), "Описание кафедры ПОВТиАС\nОписание кафедры ПОВТиАС\n\n[Нажмите сюда чтобы закрыть!]")) {
 bool = false;
 Destroy(gameObject);

 }
 }

 }