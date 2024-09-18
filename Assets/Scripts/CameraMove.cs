using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private Vector3 Origin;
    private Vector3 Difference;
    private Vector3 ResetCamera;

    private bool drag = false;

    // References to empty GameObjects placed at the map's edges
    public Transform topLeftBoundary;
    public Transform bottomRightBoundary;

    private void Start()
    {
        ResetCamera = Camera.main.transform.position;
    }

    private void LateUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            Difference = (Camera.main.ScreenToWorldPoint(Input.mousePosition)) - Camera.main.transform.position;
            if (!drag)
            {
                drag = true;
                Origin = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
        }
        else
        {
            drag = false;
        }

        if (drag)
        {
            Vector3 newPosition = Origin - Difference;

            // Get the boundaries from the GameObjects' positions
            float minX = topLeftBoundary.position.x;
            float maxX = bottomRightBoundary.position.x;
            float minY = bottomRightBoundary.position.y;
            float maxY = topLeftBoundary.position.y;

            // Clamp the camera's position to stay within the boundaries
            newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);
            newPosition.y = Mathf.Clamp(newPosition.y, minY, maxY);

            Camera.main.transform.position = newPosition;
        }

        // Reset the camera position with the right mouse button
        if (Input.GetMouseButton(1))
        {
            Camera.main.transform.position = ResetCamera;
        }
    }
}
