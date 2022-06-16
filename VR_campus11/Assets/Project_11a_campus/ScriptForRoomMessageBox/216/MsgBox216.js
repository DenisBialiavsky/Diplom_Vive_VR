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
 if(GUI.Button (Rect (500, 300, 500, 80), "Ты находишься в аудитории №216\nСейчас здесь происходит обыденный урок по изучению базы данных!\nОсмотрись внимательно и подойди к преподавателю, однако постарайся не шуметь.\n[Нажми сюда чтобы закрыть!]")) {
 bool = false;
 Destroy(gameObject);

 }
 }

 }