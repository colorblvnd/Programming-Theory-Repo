using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE (Animal child class)

public class ChickenStats : Animal
{

    private float flyPower;

    void Awake()
    {
        health = 2;
        speed = 3;
        stamina = 4;
        jumpPower = 7;
        biteDamage = 1;
        AnimalName = "Chicken";
        flyPower = 3;
        specialAbilities.Add("Fly() - Lets the chicken fly");
        rb = GetComponent<Rigidbody>();
;
    }

    // POLYMORPHISM (Overridden RemoveHealth method)
    protected override void OnMouseDown()
    {
        base.OnMouseDown();
        if (!ableToJump)
        {
            Fly();
        }
    }

    // POLYMORPHISM (Unique method to the chicken)
    public void Fly()
    {
        //Upward force applied to simulate flying
        rb.AddForce(Vector3.up * flyPower, ForceMode.Impulse);
    }
}
