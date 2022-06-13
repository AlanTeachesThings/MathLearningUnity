using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overlay31Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Activate()
    {
        GameObject.Find("Main Camera").GetComponent<CameraControlScript>().Zoom(5f, new Vector3(0f, 0f, -20f));
        GameObject.Find("Main Camera").GetComponent<CameraControlScript>().trackPlayer = false;
    }
}
