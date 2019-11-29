using System;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;
    bool isDead = false;

    public bool IsDead { get => isDead; }

    public void TakeDamage(float damage)
    {
        BroadcastMessage("OnDamageTaken");
        hitPoints = Mathf.Max(hitPoints - damage, 0);
        if (hitPoints == 0) Die();
    }

    public void Die()
    {
        if (isDead) return;
        isDead = true;
        GetComponent<Animator>().SetTrigger("die");
        GetComponent<CapsuleCollider>().enabled = false;
    }
}