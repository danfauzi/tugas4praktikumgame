using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC4 : MonoBehaviour
{
    public float moveSpeed = 1.5f;
    public float moveDistance = 3f; // jarak patroli

    private Vector3 startPos;
    private bool movingUp = true;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        Patrol();
    }

    void Patrol()
    {
        float direction = movingUp ? 1f : -1f;
        transform.Translate(Vector3.up * direction * moveSpeed * Time.deltaTime);

        // batas atas
        if (movingUp && transform.position.y >= startPos.y + moveDistance)
        {
            movingUp = false;
        }
        // batas bawah
        else if (!movingUp && transform.position.y <= startPos.y - moveDistance)
        {
            movingUp = true;
        }
    }
}