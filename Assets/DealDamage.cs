using UnityEngine;

public class DealDamage : MonoBehaviour
{
    [SerializeField] private float damage;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            BarrierHealth enemy = other.GetComponent<BarrierHealth>();
            enemy.TakeDamage(damage);
        }
    }
}
