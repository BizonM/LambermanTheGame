using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform cameraTransform;
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Vector3 offset;
    
    
    void Update()
    {
        cameraTransform.position = playerTransform.position + offset;
    }
}
