using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{


    public void Menu()
    {
        // Load Scene with buildIndex 0 which is in this case the main menu
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

}
