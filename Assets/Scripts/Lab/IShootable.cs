using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShootable
{
   Transform SpawnPoint {  get; set; }

   GameObject Bullet { get; set; }

    float RelodeTime { get; set; }
    float WaitTime { get; set; }

    void Shoot();


}
