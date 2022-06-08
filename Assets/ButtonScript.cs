using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Advance()
    {
        GameObject.Find("Froggy").GetComponent<FroggyScript>().Reset();
        GameObject.Find("OverlayManager").GetComponent<OverlayManager>().Advance();
    }
}
