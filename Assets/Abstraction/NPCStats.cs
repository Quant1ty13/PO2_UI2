using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NPCStats : MonoBehaviour
{
    [SerializeField] private string npcName;
    [SerializeField] private int level;
    [SerializeField] private float speed;
    [SerializeField] protected int health;
    [SerializeField] private int armor;
    [SerializeField] private int damage;

    protected abstract void Movement();

    protected abstract void Attack();
}
