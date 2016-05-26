using UnityEngine;
using System.Collections;

public class CamMovement : MonoBehaviour {

    public float speed = 1.5f;

    void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
    }
}
