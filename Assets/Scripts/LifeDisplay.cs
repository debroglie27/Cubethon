using UnityEngine;
using UnityEngine.UI;

public class LifeDisplay : MonoBehaviour
{
    public Text lifeText;
    public static int lifeNum = 3;

    void Update()
    {
        lifeText.text = "LIFE: " + lifeNum.ToString("0");

        if (lifeNum == 0)
        {
            FindObjectOfType<GameManager>().LevelFailed();
        }
    }
}
