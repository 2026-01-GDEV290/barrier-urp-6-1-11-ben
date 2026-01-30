using UnityEngine;

public class DestroyCreate : MonoBehaviour
{

    public GameObject tennaNormal;
    public GameObject tennaDamaged_1;
    public GameObject tennaDamaged_2;
    public GameObject fracturedTenna;

    public ScreenShake shakeScreen;

    private Quaternion targetRotation;

    private float breakForce = 20f;


    private GameObject instance1;
    private GameObject instance2;
    private GameObject instance3;

    void Start()
    {
        targetRotation = Quaternion.Euler(0f, 180f, 0f);
    }


    public void DestroyTennaNormal()
    {
        

        Destroy(tennaNormal);

        //Creates slightly damaged tenna
        
        instance1 = Instantiate(tennaDamaged_1, new Vector3(32.71f, 5.92f, 20.05f), targetRotation);
        //instance1.transform.localScale = new Vector3(171.9393f, 171.9393f, 171.9393f);


    }

    public void DestroyDamagedTenna()
    {
        //Quaternion targetRotation = Quaternion.Euler(0f, 180f, 0f);

        Destroy(instance1);

        instance2 = Instantiate(tennaDamaged_2, new Vector3(32.71f, 5.92f, 20.05f), targetRotation);
        //Creates more damaged tenna
        //Instantiate(tennaDamaged_2, new Vector3(32.71f, 5.92f, 20.05f), targetRotation).transform.localScale = new Vector3(171.9393f, 171.9393f, 171.9393f);
    }

    public void DestroyMoreDamagedTenna()
    {
        //Quaternion targetRotation = Quaternion.Euler(0f, 180f, 0f);

        shakeScreen.BeginShaking();

        Destroy(instance2);

        instance3 = Instantiate(fracturedTenna, new Vector3(32.71f, 5.92f, 20.05f), targetRotation);

        foreach(Rigidbody rb in instance3.GetComponentsInChildren<Rigidbody>())
        {
            //Vector3 force = (rb.transform.position - transform.position).normalized * breakForce;
            //Vector3 force = 
            rb.AddForce(transform.forward * breakForce, ForceMode.Impulse);
        }
    }
}
