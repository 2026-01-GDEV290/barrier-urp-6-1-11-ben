using System;
using UnityEngine;

public class BarrierHealth : MonoBehaviour
{
    [SerializeField] private float health;
    public bool isDestroyed;

    private void Start()
    {
        isDestroyed = false;

    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        Debug.Log(health);

        if(health <= 0)
        {
            isDestroyed = true;
            Debug.Log("Is Wall Destoyed: "+ isDestroyed);
            Destroy(gameObject);
            
        }
    }

   
}
