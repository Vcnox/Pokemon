using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : Character
{
    protected override void Start()
    {
        base.Start();
        damage = 10f; // Daño por defecto
    }

    public override float Attack()
    {
        float finalDamage = damage;
        if (health < 20f) finalDamage *= 3f; // Triple daño si vida < 20
        return finalDamage;
    }

    public override float Heal()
    {
        float healAmount = Attack() * 0.5f; // Se cura la mitad del daño
        health += healAmount;
        health = Mathf.Min(health, 100f);
        return health;
    }

}
