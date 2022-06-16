var Lamp1 : Light;
private var Stay : boolean;



function OnTriggerEnter(other : Collider)
 {
   if(other.GetComponent.<Collider>().tag == "Player")
     {
     Stay=true;
     }
     
     }
     
 function OnTriggerExit(other : Collider)
 {
   if(other.GetComponent.<Collider>().tag == "Player")
     {
     Stay=false;
     }
     
     } 
        
function Update () 
{
if(Input.GetKeyDown(KeyCode.E)&& Stay)
 {

	Lamp1.enabled=!Lamp1.enabled;
 }
    
}