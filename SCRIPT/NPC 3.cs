using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC3 : MonoBehaviour
{
    public float moveSpeed = 1.5f;
    public float moveDistance = 3f;

    private Vector3 startPos;
    private bool movingRight = true;
    private bool isWaiting = false;

    void Start()
    {
        startPos = transform.position;
        StartCoroutine(SneakyBehavior());
    }

    IEnumerator SneakyBehavior()
    {
        while (true)
        {
            // Jalan pelan
            float moveTime = Random.Range(2f, 4f);
            float timer = 0f;

            while (timer < moveTime)
            {
                if (!isWaiting)
                {
                    float direction = movingRight ? 1f : -1f;
                    transform.Translate(Vector3.right * direction * moveSpeed * Time.deltaTime);
                }

                timer += Time.deltaTime;
                yield return null;
            }

            // Kadang berhenti (kayak lagi cek situasi)
            isWaiting = true;
            yield return new WaitForSeconds(Random.Range(1f, 3f));
            isWaiting = false;

            // Ganti arah + BALIK BADAN
            movingRight = !movingRight;
            Flip();
        }
    }

    void Flip()
    {
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}