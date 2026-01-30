using UnityEngine;

public class DestroyCreate : MonoBehaviour
{

    public GameObject tennaNormal;
    public GameObject tennaDamaged_1;
    public GameObject tennaDamaged_2;
    private Quaternion targetRotation;

    void Start()
    {
        targetRotation = Quaternion.Euler(0f, 180f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DestroyTennaNormal()
    {
        

        Destroy(tennaNormal);

        Instantiate(tennaDamaged_1, new Vector3(32.71f, 5.92f, 20.05f), targetRotation).transform.localScale = new Vector3(171.9393f, 171.9393f, 171.9393f);

    }

    public void DestroyDamagedTenna()
    {
        //Quaternion targetRotation = Quaternion.Euler(0f, 180f, 0f);

        Destroy(tennaDamaged_1);

        Instantiate(tennaDamaged_2, new Vector3(32.71f, 5.92f, 20.05f), targetRotation).transform.localScale = new Vector3(171.9393f, 171.9393f, 171.9393f);
    }

    public void DestroyMoreDamagedTenna()
    {
        //Quaternion targetRotation = Quaternion.Euler(0f, 180f, 0f);

        Destroy(tennaDamaged_2);

        //Instantiate(tennaDamaged_2, new Vector3(32.71f, 5.92f, 20.05f), targetRotation).transform.localScale = new Vector3(171.9393f, 171.9393f, 171.9393f);
    }
}
