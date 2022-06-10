using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overlay24Script : MonoBehaviour
{
    private GameObject hazard;

    // Start is called before the first frame update
    void Start()
    {
 
    }

    public void Activate()
    {
        hazard = GameObject.Find("Hazard");
        GameObject.Find("Main Camera").GetComponent<CameraControlScript>().Zoom(5f, new Vector3(0f, 0f, -20f));
        GameObject.Find("Main Camera").GetComponent<CameraControlScript>().trackPlayer = false;
        if (hazard != null)
        {
            hazard.SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
