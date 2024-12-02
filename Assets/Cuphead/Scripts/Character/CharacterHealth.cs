using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHealth : MonoBehaviour
{
    public bool isPlayer = false;
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
            if (isPlayer)
            {
                FindObjectOfType<DataUser>().GameOver(EndGameState.Lose);
            }

            Debug.Log(gameObject.name + " - DEATH");
            Destroy(gameObject);
        }
    }
}
