using UnityEngine;

public class OrbitCamera : MonoBehaviour
{
    public Transform target;
    public float distance = 5f;
    public float sensitivity = 3f;

    float rotX;
    float rotY;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void LateUpdate()
    {
        rotX += Input.GetAxis("Mouse X") * sensitivity;
        rotY -= Input.GetAxis("Mouse Y") * sensitivity;

        rotY = Mathf.Clamp(rotY, -30f, 60f);

        Quaternion rotation = Quaternion.Euler(rotY, rotX, 0);

        Vector3 offset = rotation * new Vector3(0, 0, -distance);
        transform.position = target.position + offset;

        transform.LookAt(target);
    }
}
