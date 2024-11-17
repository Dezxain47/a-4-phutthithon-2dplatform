using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character, IShootable
{
    [field: SerializeField] public GameObject Bullet { get; set; }
    [field: SerializeField] public Transform BulletSpawnPoint { get; set; }
    public float BulletWaitTime { get; set; }
    public float BulletTimer { get; set; }
    public void Shoot()
    {
       
        if (Input.GetButtonDown("Fire1") && (BulletTimer < 0))
        {
            GameObject obj = Instantiate(Bullet, BulletSpawnPoint.position, Quaternion.identity);
            Banana banana = obj.GetComponent<Banana>();
            banana.Init(10, this);
            BulletTimer = BulletWaitTime;
        }
    }

    private void Start()
    {
        Init(100);
        BulletWaitTime = 0.0f;
        BulletTimer = 2.0f;
    }

    private void Update()
    {
        Shoot();
    }

    private void FixedUpdate()
    {
        BulletTimer -= Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Enemy enemy = collision.gameObject.GetComponent<Enemy>();
        if (enemy != null)
        {
            OnHitWith(enemy);
        }
    }

    public void OnHitWith(Enemy enemy)
    {
        TakeDamage(enemy.DamageHit);
    }

}
