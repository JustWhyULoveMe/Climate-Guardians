using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Camera cam;
    private Vector3 dragOrigin;

    [SerializeField] private float zoomStep, minCamSize, maxCamSize;


    [SerializeField] private SpriteRenderer mapRender;

    private float mapMinX, mapMaxX, mapMinY, mapMaxY;


    private void Awake()
    {
        mapMinX = mapRender.transform.position.x - mapRender.bounds.size.x / 2f;
        mapMaxX = mapRender.transform.position.x + mapRender.bounds.size.x / 2f;

        mapMinY = mapRender.transform.position.y - mapRender.bounds.size.y / 2f;
        mapMaxY = mapRender.transform.position.y + mapRender.bounds.size.y / 2f;


    }



    private void Update()
    {
        PanCamera();

        if (Input.GetAxis("Mouse ScrollWheel") > 0f) // forward

        {

            ZoomIn();

        }

        else if (Input.GetAxis("Mouse ScrollWheel") < 0f) // backwards

        {

            ZoomOut();

        }
    }


    private void PanCamera()
    {
        if (Input.GetMouseButtonDown(0))
        {
            dragOrigin = cam.ScreenToWorldPoint(Input.mousePosition);
        }    

        if (Input.GetMouseButton(0))
        {
            Vector3 difference = dragOrigin - cam.ScreenToWorldPoint(Input.mousePosition);



            cam.transform.position = ClampCamera(cam.transform.position + difference);


        }
    }



    public void ZoomIn()
    {
        float newSize = cam.orthographicSize + zoomStep;
        cam.orthographicSize = Mathf.Clamp(newSize, minCamSize, maxCamSize);

        cam.transform.position = ClampCamera(cam.transform.position);
    }

    public void ZoomOut()
    {
        float newSize = cam.orthographicSize - zoomStep;
        cam.orthographicSize = Mathf.Clamp(newSize, minCamSize, maxCamSize);

        cam.transform.position = ClampCamera(cam.transform.position);
    }


    private Vector3 ClampCamera(Vector3 targetPosition)
    {
        float camHeight = cam.orthographicSize;
        float camWidth = cam.orthographicSize * cam.aspect;

        float minX = mapMinX + Mathf.Min(camWidth, mapRender.bounds.size.x / 2f);
        float maxX = mapMaxX - Mathf.Min(camWidth, mapRender.bounds.size.x / 2f);
        float minY = mapMinY + camHeight;
        float maxY = mapMaxY - camHeight;

        float newX = Mathf.Clamp(targetPosition.x, minX, maxX);
        float newY = Mathf.Clamp(targetPosition.y, minY, maxY);

        return new Vector3(newX, newY, targetPosition.z);


    }


}
