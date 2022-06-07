using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overlay13Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Activate()
    {
        GameObject.Find("ValueHandler").GetComponent<ValueHandlerScript>().verticalForce = 0;
    }
}
