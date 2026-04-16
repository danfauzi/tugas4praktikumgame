using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float rotationSpeed = 50f;
    public float maxAngle = 45f;

    private float currentAngle = 0f;
    private bool rotateRight = true;

    void Update()
    {
        float rotationStep = rotationSpeed * Time.deltaTime;

        if (rotateRight)
        {
            transform.Rotate(0, rotationStep, 0);
            currentAngle += rotationStep;

            if (currentAngle >= maxAngle)
            {
                rotateRight = false;
            }
        }
        else
        {
            transform.Rotate(0, -rotationStep, 0);
            currentAngle -= rotationStep;

            if (currentAngle <= -maxAngle)
            {
                rotateRight = true;
            }
        }
    }
}