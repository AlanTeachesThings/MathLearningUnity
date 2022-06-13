using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Overlay15Script : MonoBehaviour
{
    private ValueHandlerScript v;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Activate()
    {
        v = GameObject.Find("ValueHandler").GetComponent<ValueHandlerScript>();
        GameObject.Find("VerticalForce").transform.Find("Slider").GetComponent<Slider>().value = v.verticalForce;
        GameObject.Find("HorizontalForce").transform.Find("Slider").GetComponent<Slider>().value = v.horizontalForce;
        GameObject.Find("Gravity").transform.Find("Slider").SendMessage("Activate");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
