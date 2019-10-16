
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player; // Score would change with position of player, Hence take transform component
    public Text ScoreText; // Create a text object and link field with this script

    // Update is called once per frame
    void Update()
    { 
      ScoreText.text=player.position.z.ToString("0"); // Making initial score zero and would update if player moves along z-axis
     
    }
}
 
