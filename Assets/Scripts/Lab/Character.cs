using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] private int health;
    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
        }
    }

    public Animator anim;
    public Rigidbody2D rb;
    public string owner;

    public bool IsDead()
    {
        return Health <= 0;
    }
    public void takeDmage(int damage)
    {
        Health -= damage;
    }
    public void Init(int newHealth)
    {
        Health = newHealth;
    }
}
