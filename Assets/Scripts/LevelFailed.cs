using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFailed : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ExitGame()
    {
        // Debug.Log("GAME EXITED!");
        Application.Quit();
    }

    public void LifeReset()
    {
        LifeDisplay.lifeNum = 3;
    }

}
