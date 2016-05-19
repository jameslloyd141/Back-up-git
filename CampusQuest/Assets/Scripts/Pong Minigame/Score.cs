using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public GameObject ballPrefab;

    int playerScore;

    public Transform paddleLeft, paddleRight;

    void Start()
    {
        playerScore = 0;
    }

	// Use this for initialization
    void Update()
    {
        Debug.Log(playerScore);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag ("PongBall"))
        {
            UpdateScore(1);
            Destroy(other.gameObject);
            Invoke("ResetPositions", 3);
        }
    }

    public void UpdateScore(int newScore)
    {
        playerScore += newScore;
        scoreText.text = "Player Score: " + playerScore.ToString();
    }

    public void ResetPositions()
    {
        paddleLeft.position = new Vector3(-22, 0, 0);
        paddleRight.position = new Vector3(22, 0, 0);
        Instantiate(ballPrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
