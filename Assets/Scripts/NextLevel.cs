using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public void LoadNextLevel()
    {
        LifeDisplay.lifeNum = 3;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
