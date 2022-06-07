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
        //GameObject.Find("ValueHandler").GetComponent<ValueHandlerScript>().verticalForce = this.GetComponent<Slider>().value;
    }
    
    public void UpdateVerticalForce()
    {
        GameObject.Find("ValueHandler").GetComponent<ValueHandlerScript>().verticalForce = this.GetComponent<Slider>().value;
    }

    public void UpdateHorizontalForce()
    {
        GameObject.Find("ValueHandler").GetComponent<ValueHandlerScript>().horizontalForce = this.GetComponent<Slider>().value;
    }

    public void UpdateGravityScale()
    {
        GameObject.Find("ValueHandler").GetComponent<ValueHandlerScript>().gravityScale = this.GetComponent<Slider>().value;
    }
}
