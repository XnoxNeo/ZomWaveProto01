using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Stat", menuName = "ScriptableObjects/Stats", order = 1)]
public class EntityStats : ScriptableObject
{
    public int maxHealth;
    public int damage;

    public float detectionRange;

    public float speed;
    public float scale;
}
