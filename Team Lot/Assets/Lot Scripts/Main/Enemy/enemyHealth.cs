using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyHealth : MonoBehaviour {

    public float enemyMaxHealth;

    public GameObject enemyDeathFX;
    public Slider enemySlider;

    float currentHealth;

    void Start()
    {
        currentHealth = enemyMaxHealth;

        enemySlider.maxValue = currentHealth;
        enemySlider.value = currentHealth;
    }

    public void addDamage(float damage)
    {
        enemySlider.gameObject.SetActive(true);

        currentHealth -= damage;
        enemySlider.value = currentHealth;

        if(currentHealth <= 0)
        {
            makeDead();
        }
    }

    void makeDead()
    {
        Destroy(gameObject);
        Instantiate(enemyDeathFX, transform.position, transform.rotation);
		Tank1_GameManager.money += 100;
    }

}
