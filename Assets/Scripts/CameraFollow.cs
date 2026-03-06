using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform cameraFollowTarget;
    [SerializeField] private float displacementMultiplier = 0.15f;
    [SerializeField] private float zPosition = -10;

    private void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 cameraDisplacement = (mousePosition - cameraFollowTarget.position) * displacementMultiplier;

        Vector3 finalCameraPosition = cameraFollowTarget.position + cameraDisplacement;
        finalCameraPosition.z = zPosition;
        transform.position = finalCameraPosition;
    }
}
