using System;
using UnityEngine;

public class BarrierHealth : MonoBehaviour
{
    [SerializeField] private float health;
    public bool isDestroyed;

    public ScreenShake shakeScreen;

    public DestroyCreate destroyAndCreate;

    private void Start()
    {
        isDestroyed = false;

    }

    public void TakeDamage(float damage)
    {


        health -= damage;


        if (health == 2)
        {
            destroyAndCreate.DestroyTennaNormal();


            Debug.Log("Current Health " + health);
            Debug.Log("Now showing Tenna with first damage");
        }
        
        if(health == 1)
        {
            GameObject tennaTwo = GameObject.Find("Tenna_Updater");
            destroyAndCreate = tennaTwo.GetComponent<DestroyCreate>();
            //destroyAndCreate = GameObject.Find("Tenna_Updater");

            destroyAndCreate.DestroyDamagedTenna();
            //destroyAndCreate.CreateWorstTenna();

            Debug.Log("Hits left " + health);
            Debug.Log("Now showing Tenna with more damage");
        }

        //Debug.Log(health);

        /*if (health <= 0)
        {
            shakeScreen.BeginShaking();

            //isDestroyed = true;
            //Debug.Log("Is Wall Destoyed: "+ isDestroyed);
            Destroy(gameObject);



        }*/
    }

    /*if (shakeScreen != null)
        {
            Debug.Log("Shake has occurred!");
        }
        else
        {
            Debug.Log("Shake didn't work.");
        }*/


}
