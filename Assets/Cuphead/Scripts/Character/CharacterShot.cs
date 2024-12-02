using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterShot : MonoBehaviour
{
    public Transform shotPos;
    public GameObject bulletPrefab;
    public AudioClip shotSFX;
    public void Shot()
    {
        if (shotSFX != null)
        {
            FindAnyObjectByType<AudioManager>().PlayAudio(shotSFX);
        }
        var bullet = Instantiate(bulletPrefab, shotPos.position, shotPos.rotation);
        Destroy(bullet, 5f);
    }
}
