using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHealth : MonoBehaviour
{
    public float maxHealth;
    public float currentHealth;

    public virtual void Start()
    {
        currentHealth = maxHealth;
    }

    public virtual void TakeDamage(float damage)
    {
        currentHealth -= damage;

        Debug.Log(gameObject.name + " Take damage: " + damage);
        if (currentHealth <= 0)
        {
            Debug.Log(gameObject.name + " - DEATH");
            Destroy(gameObject);
        }
    }
}
