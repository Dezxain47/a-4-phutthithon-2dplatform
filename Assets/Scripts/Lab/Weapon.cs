using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class Weapon : MonoBehaviour
{
    public string owner;
    public abstract void Move();
    public abstract void OnHitWith(Character character);
    public int GetShootDirection()
    {
        return 1; 
    }
}
