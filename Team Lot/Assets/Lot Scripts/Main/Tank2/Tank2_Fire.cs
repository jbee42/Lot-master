using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank2_Fire : MonoBehaviour {

    public KeyCode fire;

    public Transform gunTip;
    public GameObject bullet;
    float fireRate = 0.5f;
    float nextFire = 0f;
    bool facingRight;

    void Update()
    {
        if (Input.GetKey(fire))
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
                Instantiate(bullet, gunTip.position, Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            else if (!facingRight)
            {
                Instantiate(bullet, gunTip.position, Quaternion.Euler(new Vector3(0, 0, -180f)));
            }
        }
    }
}
