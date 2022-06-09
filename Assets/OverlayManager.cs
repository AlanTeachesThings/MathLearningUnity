using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OverlayManager : MonoBehaviour
{
    public GameObject[] basicOverlays;
    private int currentOverlay = 0;

    // Start is called before the first frame update
    void Start()
    {
        
        foreach (GameObject currentObject in basicOverlays)
        {
            currentObject.SetActive(false);
        }
        basicOverlays[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Advance()
    {
        basicOverlays[currentOverlay].SetActive(false);
        currentOverlay++;
        basicOverlays[currentOverlay].SetActive(true);
        basicOverlays[currentOverlay].SendMessage("Activate",null, SendMessageOptions.DontRequireReceiver);
    }

    public void Return()
    {
        basicOverlays[currentOverlay].SetActive(false);
        currentOverlay--;
        basicOverlays[currentOverlay].SetActive(true);
        basicOverlays[currentOverlay].SendMessage("Activate", null, SendMessageOptions.DontRequireReceiver);
    }
}
