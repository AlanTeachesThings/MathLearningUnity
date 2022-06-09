using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Overlay32Script : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Main Camera").GetComponent<CameraControlScript>().Zoom(10f, new Vector3(5f, 2f, -20f));
        GameObject.Find("Main Camera").GetComponent<CameraControlScript>().trackPlayer = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FrogLanded()
    {
        GameObject.Find("ValueHandler").GetComponent<ValueHandlerScript>().jumpsCounted++;
        GameObject.Find("JumpCounter").GetComponent<Text>().text = GameObject.Find("ValueHandler").GetComponent<ValueHandlerScript>().jumpsCounted.ToString();
    }
}
