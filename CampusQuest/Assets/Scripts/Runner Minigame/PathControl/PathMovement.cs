using UnityEngine;
using System.Collections;

public class PathMovement : MonoBehaviour
{
    public CharacterController controller;

    // Update is called once per frame
    void Update()
    {
        Vector3 backwards = transform.TransformDirection(Vector3.back);
        float currentSpeed = PathControl.control.pathSpeed * Time.deltaTime;
        controller.Move(backwards * currentSpeed);
    }
}
