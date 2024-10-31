using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementAI : MonoBehaviour
{
    public CharacterShot shotBehavior;
    public float speed;
    public float yMax;
    public float yMin;
    public bool isGoUp;

    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        if (isGoUp)
        {
            if (transform.position.y > yMax)
            {
                isGoUp = false;
            }
            else
            {
                transform.position += Vector3.up * speed * Time.deltaTime;
            }
        }
        else
        {
            if (transform.position.y < yMin)
            {
                isGoUp = true;
            }
            else
            {
                transform.position += Vector3.down * speed * Time.deltaTime;
            }
        }
    }
}
