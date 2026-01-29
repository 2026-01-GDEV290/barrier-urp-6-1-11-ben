using System;
using UnityEngine;

public class BarrierHealth : MonoBehaviour
{
    [SerializeField] private float health;
    public bool isDestroyed;

    public GameObject tennaNormal;
    public GameObject tennaDamaged_1;
    public GameObject tennaDamaged_2;

    public bool tennaNormal_isDestroyed = false;

    public ScreenShake shakeScreen;

    public DestroyCreate destroyAndCreate;

    private void Start()
    {
        isDestroyed = false;

        /*if (shakeScreen != null)
        {
            Debug.Log("Shake has occurred!");
        }
        else
        {
            Debug.Log("Shake didn't work.");
        }*/

        

    }

    public void TakeDamage(float damage)
    {

        //Quaternion targetRotation = Quaternion.Euler(0f, 180f, 0f);

        health -= damage;


        if (health == 2)
        {
            destroyAndCreate.DestroyTennaNormal();
            //Destroy(tennaNormal);

            //tennaNormal_isDestroyed=true;

            //Instantiate(tennaDamaged_1, new Vector3(32.71f, 5.92f, 20.05f), targetRotation).transform.localScale = new Vector3(171.9393f, 171.9393f, 171.9393f);

            Debug.Log("Current Health " + health);
            Debug.Log("Now showing Tenna Damage 1");
        }
        
        if(health == 1)
        {
            //Destroy(tennaDamaged_1);

            //Instantiate(tennaDamaged_2, new Vector3(32.71f, 5.92f, 20.05f), targetRotation).transform.localScale = new Vector3(171.9393f, 171.9393f, 171.9393f);

            destroyAndCreate.DestroyDamagedTenna();

            Debug.Log("Hits left " + health);
            Debug.Log("Now showing Tenna Damage 2");
        }

        //Debug.Log(health);

        if (health <= 0)
        {
            shakeScreen.BeginShaking();

            //isDestroyed = true;
            //Debug.Log("Is Wall Destoyed: "+ isDestroyed);
            Destroy(gameObject);



        }
    }

   
}
