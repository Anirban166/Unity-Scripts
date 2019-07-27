using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameend = false;
    public float resdelay = 2f;
    public GameObject completelevelUI;
    public void Endgame()
    {
        if (gameend == false)
        {
            gameend = true;
            Debug.Log("The End"); //Remove, test purpose
            
            Invoke("Restart",resdelay);
        }
    }
    public void CompleteLevel()
    {
        completelevelUI.SetActive(true);
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
