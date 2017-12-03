using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank1_Fire : MonoBehaviour
{

    public KeyCode fire;

    public Transform bulletSpawnpoint;
    public GameObject bullet;
    float fireRate = 0.5f;
    float nextFire = 0f;
    bool facingRight;

    void Update()
    {
        if (Input.GetKeyDown(fire))
        {
            fireRocket();
        }
    }

    void fireRocket()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            if (facingRight)
            {
                Instantiate(bullet, bulletSpawnpoint.position, Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            else if (!facingRight)
            {
                Instantiate(bullet, bulletSpawnpoint.position, Quaternion.Euler(new Vector3(0, 0, 360f)));
            }
        }
    }
}