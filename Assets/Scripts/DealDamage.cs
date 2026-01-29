using UnityEngine;

public class DealDamage : MonoBehaviour
{
    [SerializeField] private float damage;

    public AudioSource tvSlash;
    public AudioSource wireCut;

    private void Start()
    {
        //tvSlash = GetComponent<AudioSource>();
        //wireCut = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            tvSlash.Play();
            wireCut.Play();
            BarrierHealth enemy = other.GetComponent<BarrierHealth>();
            enemy.TakeDamage(damage);
        }
    }
}
