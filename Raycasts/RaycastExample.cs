
using UnityEngine;
using System.Collections;

public class RayCastExample : MonoBehaviour 
{
    
	void Start () 
  {
	//For initializations
	}
	
	// Update is called once per frame
    void Update()
    {

        var up = transform.TransformDirection(Vector3.up);
        // note the use of var as the type. This is because in c# you 
        // can have lamda functions which open up the use of untyped variables
        // these variables can only live inside a function. 
        RaycastHit hit;
        
        Debug.DrawRay(transform.position, -up * 2, Color.green);

        if (Physics.Raycast(transform.position, -up, out hit, 2))
        {

            Debug.Log("Beep Beep");

            if (hit.collider.gameObject.name == "floor")
            {
                Destroy(GetComponent("Rigidbody"));
            }
        }
    }

}
