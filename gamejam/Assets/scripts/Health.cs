using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthAmount healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            takeDamage(10);
        }
        if (Input.GetKeyDown("backspace") & currentHealth != maxHealth)
        {
            healDamage(10);
        }
    }

    void takeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

    void healDamage(int heal)
    {
        currentHealth += heal;

        healthBar.SetHealth(currentHealth);
    }
}
