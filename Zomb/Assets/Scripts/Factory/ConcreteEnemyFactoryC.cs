using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteEnemyFactoryC : AbstractFactory
{
    [SerializeField] private Enemy enemy;
    public override Enemy Enemy { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public override Enemy CreateEnemy(Vector2 position)
    {
        return Instantiate(enemy, position, Quaternion.identity);
    }
}
