using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimButtonScript : MonoBehaviour
{
    public int AnimFrame;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateAnim()
    {
        GameObject.Find("ValueHandler").GetComponent<ValueHandlerScript>().animHeights[AnimFrame] = transform.position.y;
        Debug.Log(GameObject.Find("ValueHandler").GetComponent<ValueHandlerScript>().animHeights[AnimFrame]);
    }
}
