using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    const float MAXHEALTH = 100f;
    float health;

// Start is called before the first frame update
    void Start()
    {

        health = MAXHEALTH;
    }


    public void TakeDamage(float amount)
    {
        health -= amount;

        if (health <= 0)
        {
            health = 0;
            Die();
        }
    }


    void Die()
    {
        GetComponent<CharacerController2D>().enabled = false;
    }

}
