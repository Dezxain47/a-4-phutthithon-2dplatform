using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Rock : Weapon
{
    Rigidbody2D rb2d;  // Rigidbody2D สำหรับการใช้ Physics
    Vector2 force; 
    private void Start()
    {
        Init(20,)
        force = new Vector2(GetShootDirection() * 100, 400);
        Move();
    }
    public override void Move()
    {
        rb2d.AddForce(force, ForceMode2D.Impulse);
    }
    public override void OnHitWith(Character character)
    {
        if (character is Player)
        {
            character.TakeDamage(this.Damage);
        }
    }
}
