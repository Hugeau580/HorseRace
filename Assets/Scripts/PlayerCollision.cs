using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private playerScript playerMovementScript;


    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("Obstacle"))
        {
            Debug.Log("on a touché" + collisionInfo.collider.name);
            playerMovementScript.enabled = false;

        }
    }

   
}
