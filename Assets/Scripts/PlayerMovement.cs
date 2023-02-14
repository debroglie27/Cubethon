using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody playerRb;
    public float forwardForce = 5000f;
    public float sidewayForce = 50f;

    // Update is called once per frame
    void Update()
    {
        playerRb.AddForce(0, 0, forwardForce*Time.deltaTime);

        if(Input.GetKey("a"))
        {
            playerRb.AddForce(-sidewayForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("d"))
        {
            playerRb.AddForce(sidewayForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(playerRb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().RespawnLevel();
        }
    }
}
