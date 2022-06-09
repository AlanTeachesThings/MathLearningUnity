using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public bool ResetOnStart = true;
    public bool HiddenAtStart = false;
    public bool FrogMakesButtonAppear = false;
    // Start is called before the first frame update
    void Start()
    {
        /*if (HiddenAtStart)
        {
            transform.gameObject.SetActive(false);
        }

        if (FrogMakesButtonAppear)
        {
            DeActivate();
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Advance()
    {
        if (ResetOnStart)
        {
            GameObject.Find("Froggy").GetComponent<FroggyScript>().Reset();
        }
        
        GameObject.Find("OverlayManager").GetComponent<OverlayManager>().Advance();
    }

    public void Return()
    {
        GameObject.Find("Froggy").GetComponent<FroggyScript>().Reset();
        GameObject.Find("OverlayManager").GetComponent<OverlayManager>().Return();
    }

    public void ReActivate()
    {
        transform.gameObject.SetActive(true);
    }

    public void DeActivate()
    {
        transform.gameObject.SetActive(false);
    }

}
