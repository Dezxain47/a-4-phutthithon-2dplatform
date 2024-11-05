using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Banana : Weapon
{
    [SerializeField] float speed;
    private void Start()
    {
        Damage = 10;
        speed = 4.0f * GetShootDirection();
        
    }
    private void FixedUpdate()
    {
        Move();
    }

    public override void Move()
    {
        float newX = transform.position.x + speed * Time.fixedDeltaTime;
        float newY = transform.position.y;
        Vector2 newPositio = new Vector2(newX, newY);
        transform.position = newPositio;
    }
    public override void OnHitWith(Character character)
    {
        if (character is Enemy)
        {
            character.TakeDamage(this.Damage);
        }
    }
}
