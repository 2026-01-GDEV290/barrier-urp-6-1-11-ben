using UnityEngine;

public class DealDamage : MonoBehaviour
{
    [SerializeField] private float damage;

    //public ParticleSystem impact;

    //public AudioSource tvSlash;
    //public AudioSource wireCut;

    public AudioSource wireSlash;

    private void Start()
    {
        //impact.Stop();
        //tvSlash = GetComponent<AudioSource>();
        //wireCut = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            //tvSlash.Play();
            //wireCut.Play();
            //impact.Play();
            //impact.Stop();
            wireSlash.Play();
            BarrierHealth enemy = other.GetComponent<BarrierHealth>();
            enemy.TakeDamage(damage);
        }
    }
}
