using UnityEngine;

public class EndScript : MonoBehaviour
    

{
    [SerializeField] private GameManager gameManagerScript;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            Debug.Log("Le joueur à atteint la ligne");
            gameManagerScript.CompleteLevel();
        }
    }
        
}
