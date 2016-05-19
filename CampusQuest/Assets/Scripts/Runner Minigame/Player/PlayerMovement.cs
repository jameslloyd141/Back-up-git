using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public CharacterController controller;

    void Update()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float currentSpeed = speed * Time.deltaTime;
        controller.Move(forward * currentSpeed);
    }
}
