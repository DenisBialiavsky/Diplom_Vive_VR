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
 if(GUI.Button (Rect ((Screen.width / 2 - 250), (Screen.height / 2 - 100), 775, 100), "Так как ты у нас новенький,обрати свое внимание на доску и прочитай основную информацию о базах данных,"+
 "\nдальше можешь пообщаться с ребятами.\n\n[Нажми сюда чтобы закрыть!]")) {
 bool = false;
 Destroy(gameObject);

 }
 }

 }
