using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChamMoving : MonoBehaviour
{
    public float speed = 35f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }
}
