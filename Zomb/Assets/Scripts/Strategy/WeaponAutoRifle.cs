using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAutoRifle : MonoBehaviour, IWeapon
{
    [Header("Weapon Position")]
    public Transform weapon;

    [Header("Bullet Variables and Firepoint")]
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 30f;

    [Header("Pick Up")]
    private bool isPickedUp = false;
    public bool IsPickedUpp => isPickedUp;



    private void Update()
    {
        if (isPickedUp)
        {
            AimAtMouse();
        }


    }

    public void AimAtMouse()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = (mousePosition - weapon.position).normalized;


        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        weapon.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }

    public void Shoot()
    {

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();


        rb.velocity = firePoint.right * bulletSpeed;
    }


    public void PickUp(Transform playerTransform)
    {



        weapon.SetParent(playerTransform);
        weapon.transform.position = playerTransform.position;




        playerTransform.GetComponent<Shooting>().weapon = this;
        isPickedUp = true;
    }

    public void DestroyWeapon()
    {
        Destroy(this.gameObject);
    }
}
