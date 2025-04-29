using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.U2D;

public abstract class Character
{
    public float health;
    private Sprite sprite;
    private string characterName;
    protected float damage; // Derivado (se calcula o asigna en subclases)

    // Constructores (en Unity, se usa Awake/Start para inicialización)
    protected virtual void Start()
    {
        // Valores por defecto
        health = 100f;
    }

    // Constructor parametrizado (para inicializar desde subclases)
    protected void InitCharacter(string name, Sprite spr, float dmg)
    {
        characterName = name;
        sprite = spr;
        damage = dmg;
    }

    // Metodos abstractos (deben implementarse en subclases)
    public abstract float Attack();

    // Metodo virtual (puede sobrescribirse)
    public virtual float Heal()
    {
        health += 10f;
        health = Mathf.Min(health, 100f); // No superar 100
        return health;
    }

    // Getters
    public string GetName() => characterName;
    public Sprite GetSprite() => sprite;
    public float GetDamage() => damage;
}
