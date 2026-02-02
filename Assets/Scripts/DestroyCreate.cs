using UnityEngine;

public class DestroyCreate : MonoBehaviour
{

    //All Tenna References 
    public GameObject tennaNormal;
    public GameObject tennaDamaged_1;
    public GameObject tennaDamaged_2;
    public GameObject fracturedTenna;

    //calls ShakeScreen
    public ScreenShake shakeScreen;

    //Sets rotation for Tennas upon instantiating 
    private Quaternion sparks_targetRotation;

    //velocity of glass shattering
    private float breakForce = 1400f;

    //Empty vars for instances 
    private GameObject instance1;
    private GameObject instance2;
    private GameObject instance3;

    //Audio sources 
    public AudioSource glassShatter1;
    public AudioSource oneSpark;
    public AudioSource twoSpark;

    public ParticleSystem sparksVFX_1;
    public ParticleSystem lightningVFX_1;

    void Start()
    {
        //targetRotation = Quaternion.Euler(0f, 180f, 0f);
        sparksVFX_1.Stop();
        lightningVFX_1.Stop();
    }


    public void DestroyTennaNormal()
    {
        sparks_targetRotation = Quaternion.Euler(5.996f, -126.562f, 8.018f);

        Destroy(tennaNormal);

        tennaDamaged_1.transform.position = new Vector3(32.71f, 5.92f, 20.05f);

        oneSpark.Play();

        sparksVFX_1.Play();

    }

    public void DestroyDamagedTenna()
    {

        lightningVFX_1.Play();

        Destroy(tennaDamaged_1);

        tennaDamaged_2.transform.position = new Vector3(32.71f, 5.92f, 20.05f);

        oneSpark.Stop();
        twoSpark.Play();

        //instance2 = Instantiate(tennaDamaged_2, new Vector3(32.71f, 5.92f, 20.05f), targetRotation);
    }

    public void DestroyMoreDamagedTenna()
    {
        sparksVFX_1.Stop();
        lightningVFX_1.Stop();

        //Destroy(instance1);
        //Destroy(instance1);

        twoSpark.Stop();

        glassShatter1.Play();

        shakeScreen.BeginShaking();

        Destroy(tennaDamaged_2);


        fracturedTenna.transform.position = new Vector3(32.71f, 5.92f, 20.05f);

        //instance3 = Instantiate(fracturedTenna, new Vector3(32.71f, 5.92f, 20.05f), targetRotation);

        foreach(Rigidbody rb in fracturedTenna.GetComponentsInChildren<Rigidbody>())
        {
            //Vector3 force = (rb.transform.position - transform.position).normalized * breakForce;
            //Vector3 force = 
            rb.AddForce(transform.forward * breakForce, ForceMode.Acceleration);
            rb.useGravity = true;
        }
    }
}
