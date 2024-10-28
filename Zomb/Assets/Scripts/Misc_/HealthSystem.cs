using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{

    [SerializeField] public int maxHealth;
    public int MaxHealth => maxHealth;

    [SerializeField] private int currentHealth;
    public int CurrentHealth => currentHealth;


    private void Start()
    {
        currentHealth = maxHealth;


    }
    private void Update()
    {
        if(this.gameObject.tag != "Player")
        {
            if(currentHealth <= 0) 
            {
                GameManager.Instance.AddScore(100);
                Destroy(this.gameObject);
            }
           
        }
    }

    public void TakeDamage(int damage)
    {

        currentHealth -= damage;

    }

    public void HealDamage(int healing)
    {
        currentHealth += healing;
        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }


    }
}
