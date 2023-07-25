using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

// INHERITANCE (Animal parent class)

public class Animal : MonoBehaviour
{
    // ENCAPSULATION (Backing fields, accessor modifiers, setter validation)

    protected string animalName;

    protected float health;
    protected float speed;
    protected float stamina;
    protected float jumpPower;
    protected float biteDamage;

    protected List<string> specialAbilities = new List<string>();
    protected bool ableToJump;

    public string AnimalName
    {
        get { return animalName; }
        protected set
        {
            if (value.Length < 20)
            {
                animalName = value;
            }
        }
    }

    public float Health
    {
        get { return health; }
        protected set
        {
            if (value >= 0)
            {
                health = value;
            }
        }
    }

    public float Speed
    {
        get { return speed; }
        protected set
        {
            if (value >= 0)
            {
                speed = value;
            }
        }
    }

    public float Stamina
    {
        get { return stamina; }
        protected set
        {
            if (value >= 0)
            {
                stamina = value;
            }
        }
    }

    public float JumpPower
    {
        get { return jumpPower; }
        protected set
        {
            if (value >= 0)
            {
                jumpPower = value;
            }
        }
    }

    public float BiteDamage
    {
        get { return biteDamage; }
        protected set
        {
            if (value >= 0)
            {
                biteDamage = value;
            }
        }
    }


    [SerializeField] protected Rigidbody rb;

    // ABSTRACTION
    // POLYMORPHISM (Virtual method to optionally be overridden)
    public virtual void Bite(Animal other)
    {
        other.RemoveHealth(biteDamage);
    }

    public virtual void RemoveHealth(float biteDamage)
    {
        health -= biteDamage;
    }

    public void Jump()
    {
        if (ableToJump)
        {
            rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            ableToJump = false;
        }
    }

    protected virtual void OnMouseDown()
    {
        Jump();
        GameObject.Find("Stats Overlay").gameObject.GetComponent<StatsOverlay>().DisplayStats(this);
        GameObject.Find("Stats Overlay").gameObject.GetComponent<StatsOverlay>().DisplaySpecialAbilities(specialAbilities);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            ableToJump = true;
        }
    }
}
