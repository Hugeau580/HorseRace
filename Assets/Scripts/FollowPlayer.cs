using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    [SerializeField] private Transform transformPlayer;
    [SerializeField] private Vector3 Offset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transformPlayer.position + Offset;
    }
}
