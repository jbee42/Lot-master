using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank2_RocketHit : MonoBehaviour {

    public float weaponDamage;

    projectilecontroller myPC;

    public GameObject explosionEffect;

    // Use this for initialization
    void Start()
    {

        myPC = GetComponentInParent<projectilecontroller>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Tank 1 Rocket Hit
        if (other.gameObject.layer == LayerMask.NameToLayer("P1Shootable"))
        {
            myPC.removeForce();
            Instantiate(explosionEffect, transform.position, transform.rotation);
            Destroy(gameObject);
            if (other.tag == "P1Enemy")
            {
                enemyHealth hurtEnemy = other.gameObject.GetComponent<enemyHealth>();
                hurtEnemy.addDamage(weaponDamage);
            }
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        //Tank 1 Rocket Hit
        if (other.gameObject.layer == LayerMask.NameToLayer("P1Shootable"))
        {
            myPC.removeForce();
            Instantiate(explosionEffect, transform.position, transform.rotation);
            Destroy(gameObject);
            if (other.tag == "P1Enemy")
            {
                enemyHealth hurtEnemy = other.gameObject.GetComponent<enemyHealth>();
                hurtEnemy.addDamage(weaponDamage);
            }
        }
    }
}
