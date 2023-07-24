using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    [SerializeField] private float health;
    [SerializeField] private float speed;
    [SerializeField] private float stamina;
    [SerializeField] private float jumpPower;
    [SerializeField] private float biteDamage;

    [SerializeField] private string animalName;
    public string AnimalName
    {
        get { return animalName; }
        set
        {
            if (value.Length < 20)
            {
                animalName = value;
            }
        }
    }

    [SerializeField] private Rigidbody rb;

    public void Bite(Animal other)
    {
        other.RemoveHealth(biteDamage);
    }

    public void RemoveHealth(float biteDamage)
    {
        health -= biteDamage;
    }

    public void Jump(float biteDamage)
    {
        rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
    }
}
