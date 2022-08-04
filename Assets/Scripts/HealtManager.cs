using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealtManager : MonoBehaviour
{
    [SerializeField] private float maxHealth = 100f;
    [SerializeField] private float currentHealth;

    private void Awake()
    {
        currentHealth = maxHealth;
    }
    public void Hit(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Time.timeScale = 0;
        }
    }
}
