﻿using UnityEngine;
using System.Collections;

public class RacketMovement : MonoBehaviour {

    public float speed = 30;
    public string axis;

    void FixedUpdate ()
    {
        float v = Input.GetAxisRaw(axis);
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speed;
    }
}