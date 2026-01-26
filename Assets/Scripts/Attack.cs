using UnityEngine;

public class Attack : MonoBehaviour
{

    private Animator anim;
    [SerializeField] private Collider weaponCollider;

    AudioSource swordSlash;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
        swordSlash = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger(name: "Attack");
            swordSlash.Play();
        }
    }

    public void EnableWeaponCollider()
    {
        weaponCollider.enabled = true;
    }

    public void DisableWeaponCollider()
    {
        weaponCollider.enabled = false;
    }
}
