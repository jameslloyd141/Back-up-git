﻿using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    public float speed = 30;

	// Use this for initialization
	void Start () {

        GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
    }

    float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketheight)
    {
        return (ballPos.y - racketPos.y) / racketheight;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "RacketLeft")
        {
            float y = hitFactor(transform.position,
                                col.transform.position,
                                col.collider.bounds.size.y);

            Vector2 dir = new Vector2(1, y).normalized;

            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }

        if (col.gameObject.name == "RacketRight")
        {
            float y = hitFactor(transform.position,
                                col.transform.position,
                                col.collider.bounds.size.y);

            Vector2 dir = new Vector2(-1, y).normalized;

            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
    }
}
