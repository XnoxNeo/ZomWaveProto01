using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPistolA : MonoBehaviour
{
    [Header("Variables")]
    public float lifespan = 2f;
    public int damage = 4;

    [Header("SFX")]
    [SerializeField] private GameObject sfxPrefab;

    private void Start()
    {
        Destroy(gameObject, lifespan); 
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            HealthSystem healthSystem = collision.GetComponent<HealthSystem>();
            healthSystem.TakeDamage(damage);
            Instantiate(sfxPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
