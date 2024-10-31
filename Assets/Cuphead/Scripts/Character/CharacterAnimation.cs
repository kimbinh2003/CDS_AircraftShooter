using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    public Animator _animator;

    public void SetInt(string name, int value)
    {
        _animator.SetInteger(name, value);
    }
}
