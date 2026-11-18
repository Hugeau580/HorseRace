using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private Transform transformPlayer;
    [SerializeField] private TextMeshProUGUI scoreText;


    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score " + transformPlayer.position.z.ToString("0");
    }
}
