using UnityEngine;

public class Example : MonoBehaviour
{
    CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    //For example I used collision flag component's above method : (like in documentation)
    void Update()
    {
        if ((controller.collisionFlags & CollisionFlags.Above) != 0)
        {
            print("touched the ceiling");
        }
    }
}
