using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE (Animal child class)

public class CowStats : Animal
{
    void Awake()
    {
        health = 9;
        speed = 4;
        stamina = 2;
        jumpPower = 4;
        biteDamage = 3;
        AnimalName = "Cow";
        specialAbilities.Add("N/A");
        rb = GetComponent<Rigidbody>();
    }

    // POLYMORPHISM (Overridden RemoveHealth method)
    public override void RemoveHealth(float biteDamage)
    {
        //Bite damage halved due to Cow's thick hide
        health -= biteDamage / 2;
    }
}
