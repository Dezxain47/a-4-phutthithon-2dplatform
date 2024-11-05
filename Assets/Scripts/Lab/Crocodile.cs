using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crocodile : Enemy
{
    [SerializeField] private float attackRange;
    [SerializeField] private Player player;

    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform bulletSpawnPoint;
    [SerializeField] private float bulletWaitTime;
    [SerializeField] private float bulletTimer;


    private void Start()
    {
        Init(30);
        WaitTime = 0.0f;
        RelodeTme = 5.0f;
        DamageHit = 30;
        attackRange = 6;
        player = GameObject.FindObjectOfType<Player>();
    }

    private void Update()
    {
        bulletTimer -= Time.deltaTime;

        Behaviour();

        if (bulletTimer < 0)
        {
            bulletTimer = bulletWaitTime;
        }
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

    private void Shoot()
    {
        if (WaitTime >= ReloadTime)
        {
            animator.SetTrigger("Shoot");
            GameObject obj = Instantiate(bullet,bulletSpawnPoint.position, Quaternion.identity);
            Rock rockScipt = obj.GetComponent<Rock>();
            rockScipt.Init(20, this);

            WaitTime = 0;
        }
    }


}
