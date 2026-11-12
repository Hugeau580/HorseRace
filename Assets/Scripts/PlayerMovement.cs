using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 10.0f;
    [SerializeField] private Rigidbody rbPlayer;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        rbPlayer.AddForce(0.0f, 0.0f, speed);
    }
}
