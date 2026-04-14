using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal"); // A/D
        float moveY = Input.GetAxis("Vertical");   // W/S

        Vector2 movement = new Vector2(moveX, moveY);
        rb.velocity = movement * speed;
    }
}