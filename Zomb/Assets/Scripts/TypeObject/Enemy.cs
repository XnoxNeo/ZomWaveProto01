using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public abstract void Move();
    public abstract void Attack(GameObject gameObject);


}
