using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : NPCStats, IDamageable
{
    private void Start()
    {
        Movement();
        Attack();
        Damage(10);
    }
    protected override void Attack()
    {
        Debug.Log("Skeleton Attacks NPC");
    }
    protected override void Movement()
    {
        Debug.Log("Skeleton Moves");
    }

    public void Damage(int damage)
    {
        Debug.Log("Skeleton Health: " + health);
        health -= damage;
        Debug.Log("Skeleton Current Health: " + health);
    }
}
