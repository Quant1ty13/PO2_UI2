using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableBox : MonoBehaviour, IDamageable
{
    public void Damage(int damage)
    {
        Debug.Log("Box Break");
    }
}
