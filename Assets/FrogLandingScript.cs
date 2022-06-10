using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrogLandingScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("FrogLanded!");
        if (other.gameObject.name == "Froggy")
        {
            foreach (GameObject foundObject in Resources.FindObjectsOfTypeAll(typeof(GameObject)))
            {
                //Debug.Log("Sending Message to " + foundObject);
                foundObject.SendMessage("FrogLanded", transform.position.x- other.transform.position.x, SendMessageOptions.DontRequireReceiver);
            }
        }
    }
}
