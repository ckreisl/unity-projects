using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    

    bool gameHasEnded = false;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame ()
    {
        // just call it once (added boolean for that)
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        // SceneManager.GetActiveScene().buildIndex + 1
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
