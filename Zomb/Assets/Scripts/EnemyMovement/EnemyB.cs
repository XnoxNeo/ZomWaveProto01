using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyB : Enemy
{
    [Header("Stats")]
    [SerializeField] private EntityStats stats;

    private float speed;
    private float detectionRange;
    private int damage;
    private float scale;
    private HealthSystem healthSystem;

    [Header("Player Stats")]
    private Transform player;

    private void Start()
    {
        speed = stats.speed;

        detectionRange = stats.detectionRange;

        damage = stats.damage;

        scale = stats.scale;
        transform.localScale *= scale;


        player = GameObject.FindGameObjectWithTag("Player").transform;

    }

    private void Update()
    {
        if (player != null)
        {
            float distance = Vector2.Distance(transform.position, player.position);

            if (distance <= detectionRange)
            {
                Move();
            }
        }
    }

    public override void Move()
    {
        Vector2 direction = (player.position - transform.position).normalized;
        transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    }

    public override void Attack(GameObject player)
    {
        HealthSystem healthSystem = player.GetComponent<HealthSystem>();
        healthSystem.TakeDamage(damage);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Attack(collision.gameObject);
        }
    }
}
