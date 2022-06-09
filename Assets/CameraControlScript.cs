using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControlScript : MonoBehaviour
{
    private float targetOrthographicSize = 5.0f;
    private Camera c;
    
    private GameObject froggy;
    private Vector3 initialOffset;
    private Vector3 newCameraPosition;
    private Vector3 newOffset;
    private float initialCameraSize;

    private float zoomElapsedTime;
    private float positionElapsedTime;
    public float cameraSpeedFactor;

    public bool trackPlayer;


    // Start is called before the first frame update
    void Start()
    {
        c = GetComponent<Camera>();
        froggy = GameObject.Find("Froggy");
        initialOffset = c.WorldToScreenPoint(froggy.transform.position);
        initialCameraSize = c.orthographicSize;
        newCameraPosition = c.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (c.orthographicSize != targetOrthographicSize)
        {
            zoomElapsedTime += cameraSpeedFactor * Time.deltaTime;
            c.orthographicSize = Mathf.Lerp(c.orthographicSize, targetOrthographicSize, zoomElapsedTime);

        }
        else
        {
            zoomElapsedTime = 0;
        }

        if (c.transform.position != newCameraPosition)
        {
            positionElapsedTime += cameraSpeedFactor * Time.deltaTime;
            c.transform.position = Vector3.Lerp(c.transform.position, newCameraPosition, positionElapsedTime);

        }
        else
        {
            positionElapsedTime = 0;
        }

        if (trackPlayer)
        {
            froggy = GameObject.Find("Froggy");
            c.transform.position = newCameraPosition + new Vector3(froggy.transform.position.x - 5f, 0.0f, 0.0f);
        }

    }

    public void Zoom(float zoomLevel, Vector3 newPosition)
    {
        targetOrthographicSize = zoomLevel;
        newCameraPosition = newPosition;
    }
}
