using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class Weapon : MonoBehaviour
{
    [SerializeField] int damage;
    public int Damage {  get { return damage; } }
    public IShootable shooter;

    public abstract void Move();
    public abstract void OnHitWith(Character character);
    
    public void Init(int _damage,IShootable _owner)
    {
        Damage = _damage;
        shooter = _owner;

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        OnHitWith(other.GetComponent<Character>());
        Destroy(this.gameObject, 5f);
    }

    public int GetShootDirection()
    {
       float shootDir = shooter.SpawnPoint.position.x - shooter.SpawnPoint.parent.position.x;
        if (shootDir > 0)
            return 1;
        else return -1;

    }
}
