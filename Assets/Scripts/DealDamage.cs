using UnityEngine;

public class DealDamage : MonoBehaviour
{
    [SerializeField] private float damage;

    //public AudioSource tvSlash;
    //public AudioSource wireCut;

    public AudioSource wireSlash;

    private void Start()
    {
        //tvSlash = GetComponent<AudioSource>();
        //wireCut = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            //tvSlash.Play();
            //wireCut.Play();
            wireSlash.Play();
            BarrierHealth enemy = other.GetComponent<BarrierHealth>();
            enemy.TakeDamage(damage);
        }
    }
}
