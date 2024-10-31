using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleBullet : MonoBehaviour
{
    public float speed;
    public float damage;

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var characterHealth = collision.GetComponentInParent<CharacterHealth>();
        if (characterHealth != null)
        {
            characterHealth.TakeDamage(damage);
            Destroy(gameObject); // Destroy vien dan
        }
    }
}
