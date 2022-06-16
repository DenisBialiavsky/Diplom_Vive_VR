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
 if(GUI.Button (Rect (500, 300, 500, 80), "You can move by pressing the W,A,S,D Keys\nPress Space Bar to Jump, (E) Key is Action!\n\n[Click to close]")) {
 bool = false;
 Destroy(gameObject);

 }
 }

 }
