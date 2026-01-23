using UnityEngine;

public class FollowCamera2_5D : MonoBehaviour
{
    [Header("Follow Target")]
    public Transform target; // Player to follow

    [Header("Camera Settings")]
    public Vector3 offset = new Vector3(0f, 5f, -10f);
    public float followSpeed = 5f;

    private Quaternion initialRotation;

    void Start()
    {
        // Store the camera’s starting rotation so it never changes
        initialRotation = transform.rotation;
    }

    void LateUpdate()
    {
        if (!target) return;

        // Smoothly follow target position
        Vector3 desiredPosition = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, followSpeed * Time.deltaTime);

        // Keep camera rotation fixed (don’t rotate with player)
        transform.rotation = initialRotation;
    }
}