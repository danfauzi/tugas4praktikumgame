using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Polisi : MonoBehaviour
{
    public float speed = 3f;
    public float detectDistance = 5f;

    public Transform target; // drag NPC maling ke sini di inspector

    void Update()
    {
        if (target == null) return;

        float distance = Vector3.Distance(transform.position, target.position);

        // kalau maling dalam jarak deteksi ? kejar
        if (distance < detectDistance)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            transform.Translate(direction * speed * Time.deltaTime);
        }
    }
}