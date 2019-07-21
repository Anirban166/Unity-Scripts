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

