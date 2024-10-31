using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speedMovement;
    public CharacterAnimation characterAnimation;
    public CharacterShot characterShot;

    private void Update()
    {
        MovementControl();
        ShotControl();
    }

    private void ShotControl()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            characterShot.Shot();
        }
    }

    private void MovementControl()
    {
        // Get Input
        float xHorizontal = Input.GetAxisRaw("Horizontal"); // lay truc ngang phim < > -1 -> 1, 0: ko bam phim
        float yVertical = Input.GetAxisRaw("Vertical"); // lay truc doc len tren, xuong duoi -1 -> 1

        transform.position = transform.position + new Vector3(xHorizontal, yVertical, 0) * speedMovement * Time.deltaTime;
        
        if (yVertical > 0)
        {
            characterAnimation.SetInt("idle_direction", 1);
        }
        if (yVertical < 0)
        {
            characterAnimation.SetInt("idle_direction", -1);
        }
        if (yVertical == 0)
        {
            characterAnimation.SetInt("idle_direction", 0);
        }
    }
}
