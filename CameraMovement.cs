using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private Transform target;
    [SerializeField] private float distanceToTarget = 10;
    [SerializeField] [Range(0, 60)] private int maxRotationInOneSwipe = 60;
    
    private Vector3 previousPosition;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            previousPosition = cam.ScreenToViewportPoint(Input.mousePosition);
        }
        else if (Input.GetMouseButton(0))
        {
            Vector3 newPosition = cam.ScreenToViewportPoint(Input.mousePosition);
            Vector3 direction = previousPosition - newPosition;
            
            float rotationAroundYAxis = -direction.x * maxRotationInOneSwipe; // camera moves horizontally
            float rotationAroundXAxis = direction.y * maxRotationInOneSwipe; // camera moves vertically
            
            cam.transform.position = target.position;
            
            cam.transform.Rotate(new Vector3(0, 25, 0), rotationAroundYAxis);

            
            cam.transform.Translate(new Vector3(0, 0, -distanceToTarget));
            
            previousPosition = newPosition;
        }
    }
}
