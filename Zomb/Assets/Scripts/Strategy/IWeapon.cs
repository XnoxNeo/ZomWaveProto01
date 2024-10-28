using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWeapon
{
    void Shoot();
    void PickUp(Transform player);
    void DestroyWeapon();
}
