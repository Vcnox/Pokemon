using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : Character
{
    public float damageMultiplier;

    public Wizard(float multiplier, string name) // Constructor
    {
        damageMultiplier = multiplier;
        InitCharacter(name, null, 20f); // Daño base = 20
    }

    protected override void Start()
    {
        base.Start();
        damage = 20f;
    }

    public override float Attack()
    {
        return damage * damageMultiplier; // Daño escalado
    }

    public override float Heal()
    {
        float healAmount = Random.Range(damage, damage * damageMultiplier);
        health += healAmount;
        health = Mathf.Min(health, 100f);
        return health;
    }
}

