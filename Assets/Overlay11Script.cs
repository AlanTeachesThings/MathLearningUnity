using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Overlay11Script : MonoBehaviour
{
    private ValueHandlerScript v;

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
        v = GameObject.Find("ValueHandler").GetComponent<ValueHandlerScript>();
        v.horizontalForce = 0f;
        GameObject.Find("VerticalForce").transform.Find("Slider").GetComponent<Slider>().value = v.verticalForce;
        GameObject.Find("Gravity").transform.Find("Slider").SendMessage("Activate");
    }
}
