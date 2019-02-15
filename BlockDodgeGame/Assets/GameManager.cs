using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public float slowness = 10f;
    public Text scoreText;
    public int amountOfBlocks;

    private float score = 0f;

    public void AddOneToScore()
    {
        // 0.25 because of 4 blocks falling
        // each block script will trigger this function
        score += 1f / (float) amountOfBlocks;
        scoreText.text = score.ToString("0");
    }

    public void EndGame()
    {
        StartCoroutine(RestartLevel());
    }

    IEnumerator RestartLevel ()
    {
        // our current time ( unity scale time )
        Time.timeScale = 1f / slowness;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;

        // before 1 sec
        yield return new WaitForSeconds(1f / slowness);
        // after 1 sec

        // get original state
        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
