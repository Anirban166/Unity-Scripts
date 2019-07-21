//simple player-followup, use for cameras.

using UnityEngine;

public class followplayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        //  Debug.Log(player.position);  // for displaying player position (xyz) values in console
        transform.position = player.position+offset;
    }
}
