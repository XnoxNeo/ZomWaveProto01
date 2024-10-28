using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractFactory : MonoBehaviour
{
    public abstract Enemy Enemy { get; set; }
    public string enemyType;

    public abstract Enemy CreateEnemy(Vector2 position);
}
