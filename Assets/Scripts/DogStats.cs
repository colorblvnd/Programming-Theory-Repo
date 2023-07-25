using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE (Animal child class)

public class DogStats : Animal
{

    private float dashPower;

    void Awake()
    {
        health = 4;
        speed = 8;
        stamina = 6;
        jumpPower = 8;
        biteDamage = 7;
        AnimalName = "Dog";
        dashPower = 2;
        specialAbilities.Add("Dash() - Lets the dog dash forward");
        rb = GetComponent<Rigidbody>();
    }

    // POLYMORPHISM (Overridden RemoveHealth method)
    public void Dash()
    {
        //Adds force in the direction that the dog is facing
        rb.AddForce(gameObject.transform.forward * dashPower, ForceMode.Impulse);
    }
}
