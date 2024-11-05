using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Player : Character , IShootable
{
    public void Start()
    {
        if (Input.GetKeyDown("Fire1")&& WaitTime >= RelodeTime)
        {
            GameObject obj = Instantiate(bullet , SpawnPoint.position,Quaternion.identity);

        }
    }

    void Update()
    {
        Shoot();
    }
    void FixedUpdate()
    {
        WaitTime += Time.fixedDeltaTime;
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
        TakeDamage(enemy.DamegeHit);
    }
}
