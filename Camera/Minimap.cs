//Note: Use FollowPlayer script to ensure main camera is following the player.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minimap : MonoBehaviour
{
    public Transform player;
    void LateUpdate()
    {
        Vector3 newposition = player.position;
        newposition.y = transform.position.y;    // Only following across y-axis. 
        transform.position = newposition;
    }
}

//Link with minimap camera (set a canvas/UI)
 
