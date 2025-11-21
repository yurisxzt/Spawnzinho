using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;      // Player
    public Vector3 offset;        // Distância da câmera para o player
    public float smoothSpeed = 10f;

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

        transform.position = smoothPosition;

        transform.LookAt(target);
    }
}
