using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class Weapon : MonoBehaviour
{
    public string owner;
    public abstract void Move();
    public abstract void OnHitWith(Character character);
    private int damage;
    public int Damage
    {
        get
        {
            return damage;
        }
        set
        {
            damage = value;
        }
    }
    public string Owner { get; set; }

    public int GetShootDirection()
    {
        return 1; 
    }
}
