using UnityEngine;
using System.Collections;

public class RacketAI : MonoBehaviour
{
    public Transform ball;
    public Transform paddle;

    public float speed;

    void Start()
    {

    }
    void Update()
    {
        float step = speed * Time.deltaTime;
        paddle.position = Vector3.MoveTowards(paddle.position, new Vector3(paddle.position.x, ball.position.y, 0), step);
    }
}
