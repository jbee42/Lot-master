using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tank2_health : MonoBehaviour {

    public float fullHealth;
    public GameObject deathFX;
    public AudioClip playerHurt;

    float currentHealth;

    Tank1movement controlMovement;

    AudioSource playerAS;

    public Slider healthSlider;
    public Image damageScreen;

    bool damaged = false;
    Color damagedColour = new Color(0f, 0f, 0f, 0.5f);
    float smoothColour = 5f;

    // Use this for initialization
    void Start()
    {
        currentHealth = fullHealth;
        controlMovement = GetComponent<Tank1movement>();

        //HUD Initilization
        healthSlider.maxValue = fullHealth;
        healthSlider.value = fullHealth;

        damaged = false;

        playerAS = GetComponent<AudioSource>();

    }

    void Update()
    {
        if (damaged)
        {
            damageScreen.color = damagedColour;
        }
        else
        {
            damageScreen.color = Color.Lerp(damageScreen.color, Color.clear, smoothColour * Time.deltaTime);
        }
        damaged = false;
    }

    public void addDamage(float damage)
    {
        if (damage <= 0) return;
        currentHealth -= damage;

        playerAS.clip = playerHurt;
        playerAS.Play();
        //playerAS.PlayOneShot(playerHurt);


        healthSlider.value = currentHealth;

        damaged = true;

        if (currentHealth <= 0)
        {
            makeDead();
        }

    }

    public void makeDead()
    {
        //Instantiate(deathFX, transform.position, transform.rotation);
        //Destroy(gameObject);
        SceneManager.LoadScene("End");
    }
}
