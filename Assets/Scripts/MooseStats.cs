using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE (Animal child class)

public class MooseStats : Animal
{
    private float ramDamage;

    void Awake()
    {
        health = 7;
        speed = 10;
        stamina = 6;
        jumpPower = 6;
        biteDamage = 3;
        AnimalName = "Moose";
        ramDamage = 7;
        specialAbilities.Add("Ram() - Lets the moose do damage by ramming");
        rb = GetComponent<Rigidbody>();
    }

    // POLYMORPHISM (Overridden RemoveHealth method)
    public override void RemoveHealth(float biteDamage)
    {
        //Bite damage halved due to Moose's thick hide
        health -= biteDamage / 2;
    }

    // POLYMORPHISM (Unique method to the Moose)
    public void Ram(Animal other)
    {
        other.RemoveHealth(ramDamage);
    }
}
