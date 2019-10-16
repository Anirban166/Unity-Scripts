using UnityEngine;  

public class Playercollision : MonoBehaviour 
{ 
  public Playermovement movement; 
  
   void Oncollisionenter(collision collisioninfo) //a function with collision information (object,position etc) as parameter. 
   {
   
     if(collisioninfo.collider.tag=='Obstacle') //if colliding object is marked as an 'obstacle'. tags are used to mark entities of a type.
     
     {
     
      movement enabled=false; // or GetComponent<Playermovement>().enabled=false; //disable movement or force halt.
      
     }
     
   }
   
} 

//For an object like a cuboid, its box collider components'attribute field must be linked with the above script.
