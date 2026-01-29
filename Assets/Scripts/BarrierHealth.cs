using System;
using UnityEngine;

public class BarrierHealth : MonoBehaviour
{
    [SerializeField] private float health;
    public bool isDestroyed;

    public ScreenShake shakeScreen;

    private void Start()
    {
        isDestroyed = false;

        if (shakeScreen != null)
        {
            Debug.Log("Shake has occurred!");
        }
        else
        {
            Debug.Log("Shake didn't work.");
        }

    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        Debug.Log(health);

        if(health <= 0)
        {
            shakeScreen.BeginShaking();

            //isDestroyed = true;
            //Debug.Log("Is Wall Destoyed: "+ isDestroyed);
            Destroy(gameObject);
            
         

        }
    }

   
}
