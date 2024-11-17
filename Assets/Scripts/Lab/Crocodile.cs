using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Crocodile : Enemy, IShootable
{
    [SerializeField] private float attackRange;
    [SerializeField] private Player player;

    [field: SerializeField] public GameObject Bullet { get; set; }
    [field: SerializeField] public Transform BulletSpawnPoint { get; set; }
    public float BulletWaitTime { get; set; }
    public float BulletTimer { get; set; }


    private void Start()
    {
        Init(30);
        BulletWaitTime = 1.0f;
        BulletTimer = 5.0f;
    }

    private void FixedUpdate()
    {
        BulletTimer -= Time.deltaTime;

        Behaviour();


    }

    public override void Behaviour()
    {
        Vector2 direction = player.transform.position - transform.position;
        float distance = direction.magnitude;

        if (distance < attackRange)
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        if (BulletTimer < 0)
        {
            anim.SetTrigger("Shoot");
            GameObject obj = Instantiate(Bullet, BulletSpawnPoint.position, Quaternion.identity);
            Rock rockScript = obj.GetComponent<Rock>();
            rockScript.Init(20, this);
            BulletTimer = BulletWaitTime;
        }
    }


}
