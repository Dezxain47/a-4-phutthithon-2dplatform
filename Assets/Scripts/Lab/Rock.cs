using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Rock : Weapon
{
    public Rigidbody2D rb2d;  // Rigidbody2D สำหรับการใช้ Physics
    public Vector2 moveDirection;
    public int damage = 40;   // Damage as required
    private void Start()
    {
        Move();
    }
    public override void Move()
    {
        Debug.Log("Rock เคลื่อนที่ด้วย RigidBody: force");
        rb2d.AddForce(moveDirection * damage);  // ใช้ force เพื่อทำให้ rock เคลื่อนที่
    }
    public override void OnHitWith(Character character)
    {
        // อิมพลีเมนต์สำหรับการกระทำเมื่อกระทบกับตัวละคร
    }
}
