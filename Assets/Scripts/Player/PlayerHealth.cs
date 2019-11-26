using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float health = 100f;

    public void TakeDamage(float damage)
    {
        health = Mathf.Max(health - damage, 0);
        if (health <= 0)
        {
            GetComponent<DeathHandler>().HandleDeath();
        }
    }
}
