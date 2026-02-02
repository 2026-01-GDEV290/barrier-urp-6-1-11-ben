using UnityEngine;

public class DestroyCreate : MonoBehaviour
{

    public GameObject tennaNormal;
    public GameObject tennaDamaged_1;
    public GameObject tennaDamaged_2;
    public GameObject fracturedTenna;

    public ScreenShake shakeScreen;

    private Quaternion targetRotation;

    private float breakForce = 1400f;


    private GameObject instance1;
    private GameObject instance2;
    private GameObject instance3;

    public AudioSource glassShatter1;

    void Start()
    {
        targetRotation = Quaternion.Euler(0f, 180f, 0f);
    }


    public void DestroyTennaNormal()
    {
        

        Destroy(tennaNormal);

        tennaDamaged_1.transform.position = new Vector3(32.71f, 5.92f, 20.05f);
        
        //instance1 = Instantiate(tennaDamaged_1, new Vector3(32.71f, 5.92f, 20.05f), targetRotation);



    }

    public void DestroyDamagedTenna()
    {

        Destroy(tennaDamaged_1);

        tennaDamaged_2.transform.position = new Vector3(32.71f, 5.92f, 20.05f);

        //instance2 = Instantiate(tennaDamaged_2, new Vector3(32.71f, 5.92f, 20.05f), targetRotation);
    }

    public void DestroyMoreDamagedTenna()
    {
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
