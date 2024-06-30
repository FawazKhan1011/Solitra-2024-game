using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform targetToFollow;

    void Update()
    {
        transform.position = new Vector3(
            transform.position.x,
            Mathf.Clamp(targetToFollow.position.y, 0f, Mathf.Infinity),
            transform.position.z);
    }
}
    