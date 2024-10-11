using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Banana : Weapon
{
    public float speed = 4f; 
    public int damage = 30;  
    private void Start()
    {
        Move();
    }
    public override void Move()
    {
        Debug.Log("Banana เคลื่อนที่ด้วย Transform ด้วยความเร็วคงที่");
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
    public override void OnHitWith(Character character)
    {
        // อิมพลีเมนต์สำหรับการกระทำเมื่อกระทบกับตัวละคร
    }
}
