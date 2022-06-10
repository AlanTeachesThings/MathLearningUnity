using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overlay25Script : MonoBehaviour
{
    public GameObject hazard;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Activate()
    {
        hazard.SetActive(true);
    }
}
