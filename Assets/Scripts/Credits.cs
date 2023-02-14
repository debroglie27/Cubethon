using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene(0);
    }

    public void ExitGame()
    {
        // Debug.Log("GAME EXITED!");
        Application.Quit();
    }
}
