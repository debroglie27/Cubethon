using UnityEngine;

public class LevelNum : MonoBehaviour
{
    void Start()
    {
        FindObjectOfType<GameManager>().LevelNumDisplay();
    }
}
