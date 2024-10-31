using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterShot : MonoBehaviour
{
    public Transform shotPos;
    public GameObject bulletPrefab;

    public void Shot()
    {
        var bullet = Instantiate(bulletPrefab, shotPos.position, shotPos.rotation);
        Destroy(bullet, 5f);
    }
}
