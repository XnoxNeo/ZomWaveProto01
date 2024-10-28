using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [Header("Weapon")]
    [SerializeField] public IWeapon weapon;
    private Transform playerTransform;

    
    private void Start()
    {
        playerTransform = GetComponent<Transform>();
    }

    
    private void Update()
    {
        if (Input.GetButtonDown("Fire1")) 
        {
            weapon?.Shoot();
        }
    }

    
   
}
