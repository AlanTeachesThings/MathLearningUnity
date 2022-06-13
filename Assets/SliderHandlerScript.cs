using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderHandlerScript : MonoBehaviour
{
    public Text label;
    public bool isGravitySlider;
    
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
        if (isGravitySlider)
        {
            //Debug.Log("V value is "+ GameObject.Find("ValueHandler").GetComponent<ValueHandlerScript>().gravityScale);
            switch (GameObject.Find("ValueHandler").GetComponent<ValueHandlerScript>().gravityScale)
            {
                case 0f:
                    this.GetComponent<Slider>().value = 0;
                    label.text = "0G: Outer Space";
                    break;

                case 0.38f:
                    this.GetComponent<Slider>().value = 1;
                    label.text = "0.38G: Mars";
                    break;

                case 1f:
                    this.GetComponent<Slider>().value = 2;
                    label.text = "1G: Earth";
                    break;

                case 2.54f:
                    this.GetComponent<Slider>().value = 3;
                    label.text = "2.54G: Jupiter";
                    break;
            }
        }
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

    public void UpdateGravityScale(Text textObject)
    {
        GameObject.Find("ValueHandler").GetComponent<ValueHandlerScript>().gravityScale = this.GetComponent<Slider>().value;
        switch(this.GetComponent<Slider>().value)
        {
            case 0:
                GameObject.Find("ValueHandler").GetComponent<ValueHandlerScript>().gravityScale = 0f;
                textObject.text = "0G: Outer Space";
                break;
            
            case 1:
                GameObject.Find("ValueHandler").GetComponent<ValueHandlerScript>().gravityScale = 0.38f;
                textObject.text = "0.38G: Mars";
                break;

            case 2:
                GameObject.Find("ValueHandler").GetComponent<ValueHandlerScript>().gravityScale = 1f;
                textObject.text = "1G: Earth";
                break;

            case 3:
                GameObject.Find("ValueHandler").GetComponent<ValueHandlerScript>().gravityScale = 2.54f;
                textObject.text = "2.54G: Jupiter";
                break;
        }
        
    }

    public void UpdateFrequency()
    {
        GameObject.Find("ValueHandler").GetComponent<ValueHandlerScript>().frequency = this.GetComponent<Slider>().value;
    }
    
    public void UpdateAmplitude()
    {
        GameObject.Find("ValueHandler").GetComponent<ValueHandlerScript>().amplitude = this.GetComponent<Slider>().value;
    }

    public void UpdateFriction()
    {
        GameObject.Find("ValueHandler").GetComponent<ValueHandlerScript>().icePlatformFriction = this.GetComponent<Slider>().value/10;
    }

    public void UpdateBounciness(Text textObject)
    {
        GameObject.Find("ValueHandler").GetComponent<ValueHandlerScript>().bouncyPlatformBounciness = this.GetComponent<Slider>().value / 10;
        textObject.text = (this.GetComponent<Slider>().value / 10f).ToString();
    }
}
