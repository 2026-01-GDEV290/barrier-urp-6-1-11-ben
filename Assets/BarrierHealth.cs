using System;
using UnityEngine;

public class BarrierHealth : MonoBehaviour
{
    [SerializeField] private float health;
    public bool isDestroyed = false;

    public void TakeDamage(float damage)
    {
        health -= damage;
        Debug.Log(health);

        if(health <= 0)
        {
            isDestroyed = true;
            Destroy(gameObject);
            
        }
    }

   
}
