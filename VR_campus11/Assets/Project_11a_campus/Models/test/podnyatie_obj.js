var grabPower = 10.0;//скорость притяжения
var throwPower = 10;//скорость толчка
var hit : RaycastHit;//луч
var RayDistance : float = 3.0;//дистанция
private var Grab : boolean = false;//ф-ция притяжения
private var Throw : boolean = false;//ф-ция толчка
var offset : Transform;


function Update(){
if (Input.GetKey(KeyCode.E)){//если нажата клавиша Е

Physics.Raycast(transform.position, transform.forward, hit, RayDistance);//физический луч

if(hit.rigidbody){//если луч соприкасается с rigidbody
Grab = true;
}
}

if (Input.GetMouseButtonDown(0)){//если нажата лев кн мыши
if(Grab){
Grab = false;
Throw = true;
}
}

if(Grab){//ф-ция притяжения
if(hit.rigidbody){
hit.rigidbody.velocity = (offset.position - (hit.transform.position + hit.rigidbody.centerOfMass))*grabPower;
}
}

if(Throw){//ф-ция толчка
if(hit.rigidbody){
hit.rigidbody.velocity = transform.forward * throwPower;
Throw = false;
}
}
}