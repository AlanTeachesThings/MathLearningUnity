using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Overlay23Script : MonoBehaviour
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
        GameObject.Find("Gravity").transform.Find("Slider").GetComponent<Slider>().value = v.gravityScale;

        GameObject.Find("Main Camera").GetComponent<CameraControlScript>().Zoom(10f, new Vector3(5f, 2f, -20f));
        GameObject.Find("Main Camera").GetComponent<CameraControlScript>().trackPlayer = true;
    }

    void FrogLanded()
    {
        GameObject.Find("ValueHandler").GetComponent<ValueHandlerScript>().jumpsCounted++;
        GameObject.Find("JumpCounter").GetComponent<Text>().text = GameObject.Find("ValueHandler").GetComponent<ValueHandlerScript>().jumpsCounted.ToString();
    }
}
