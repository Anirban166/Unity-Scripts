//use build index:

using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
  public void startgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

//In a similar approach decrement of a level scene can be done too, altough its rarely applicable ; perhaps for games with recursive levels.
