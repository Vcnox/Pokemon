using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cowboy : Character
{
    public Cowboy(string name) // Constructor alternativo
    {
        InitCharacter(name, null, 15f); // Daño base = 15
    }

    protected override void Start()
    {
        base.Start();
        damage = 15f;
    }

    public override float Attack()
    {
        return damage * Random.Range(1f, 1.5f); // Daño aleatorio
    }

    public override float Heal()
    {
        health += 10f; // Siempre +10 de vida
        health = Mathf.Min(health, 100f);
        return health;
    }


}
