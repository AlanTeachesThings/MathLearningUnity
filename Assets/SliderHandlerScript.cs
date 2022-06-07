using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderHandlerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateText(Text textObject)
    {
        textObject.text = this.GetComponent<Slider>().value.ToString();
        GameObject.Find("ValueHandler").GetComponent<ValueHandlerScript>().verticalForce = this.GetComponent<Slider>().value;
    }
}
