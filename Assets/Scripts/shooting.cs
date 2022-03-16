using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    int delay;
    private Vector3 vel;
    private float speed = 5f;
    public float bulletForce = 10f;
    public Transform firepoint;
    public GameObject bulletPrefab;


    // Update is called once per frame
    void Update()
    {
        if (delay > 25)
        {
            Shoot();
        }

        delay++;
    }
    void Shoot()
    {
        delay = 0;
        GameObject bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firepoint.up * bulletForce, ForceMode2D.Impulse);

    }
}
