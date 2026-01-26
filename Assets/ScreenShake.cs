using UnityEngine;
using System.Collections;
public class ScreenShake : MonoBehaviour
{
    public float duration = 1.0f;
    public AnimationCurve curve;
    public bool start = false;

    public BarrierHealth barrierStatus;

    void Update()
    {
        /*if(start)
        {
            start = false;
            StartCoroutine(Shaking());
        }*/

        /*if (barrierStatus.isDestroyed)
        {
            StartCoroutine(Shaking());

        }*/

        GameObject barrier = GameObject.Find("SlashableScreen");
        if (barrier != null)
        {
            barrierStatus = barrier.GetComponent<BarrierHealth>();
            if (barrierStatus.isDestroyed)
            {
                StartCoroutine(Shaking());

            }
        }


    }

    public IEnumerator Shaking()
    {
        Vector3 startPosition = transform.position;
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float strength = curve.Evaluate(elapsedTime / duration);
            transform.position = startPosition + Random.insideUnitSphere * strength;
            yield return null;
        }

        transform.position = startPosition;
    }
}
