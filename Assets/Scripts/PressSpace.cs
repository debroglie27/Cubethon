using UnityEngine;
using UnityEngine.UI;

public class PressSpace : MonoBehaviour
{
    public Text pressSpaceText;

    void Update()
    {
        if(Input.GetKey("space"))
        {
            pressSpaceText.enabled = false;
            FindObjectOfType<GameManager>().PressSpace();
        }
    }
}
