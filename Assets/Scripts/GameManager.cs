using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;

    public GameObject CompleteLevelUI;
    public GameObject FailedLevelUI;
    public Text LevelNumUI;

    public void LevelNumDisplay()
    {
        LevelNumUI.text = "LEVEL: " + SceneManager.GetActiveScene().buildIndex.ToString("0");
    }

    public void PressSpace()
    {
        FindObjectOfType<PlayerMovement>().enabled = true;
    }

    public void LevelComplete()
    {
        CompleteLevelUI.SetActive(true);
        FindObjectOfType<PlayerMovement>().enabled = false;
    }

    public void LevelFailed()
    {
        FailedLevelUI.SetActive(true);
        FindObjectOfType<PlayerMovement>().enabled = false;
    }

    // It is called when player collides with obstacle or falls off the platform
    public void RespawnLevel()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            LifeDisplay.lifeNum -= 1;

            // Debug.Log("GAME OVER!");
            if(LifeDisplay.lifeNum != 0)
            {
                Invoke("Restart", restartDelay);
            }
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
