using UnityEngine;

public class playerScript : MonoBehaviour
{

    [SerializeField] private float speed = 10.2f;
    [SerializeField] private Rigidbody rbPlayer;
    [SerializeField] private float _sideWaysForce = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rbPlayer.AddForce(0.0f, 0.0f, speed);

        if (Input.GetKey(KeyCode.Q))
        {
            rbPlayer.AddForce(-_sideWaysForce, 0.0f, 0.0f, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rbPlayer.AddForce(_sideWaysForce, 0.0f, 0.0f, ForceMode.VelocityChange);
        }
    }
}
