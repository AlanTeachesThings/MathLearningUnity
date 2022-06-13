using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetButtonScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ResetFroggy()
    {
        //Debug.Log(GameObject.Find("JumpCounter"));
        //GameObject.Destroy(GameObject.Find("Froggy"));
        GameObject.Find("Froggy").SendMessage("Reset");
        if (GameObject.Find("JumpCounter")!= null)
        {
            GameObject.Find("ValueHandler").GetComponent<ValueHandlerScript>().jumpsCounted = 0;
            GameObject.Find("JumpCounter").GetComponent<Text>().text = GameObject.Find("ValueHandler").GetComponent<ValueHandlerScript>().jumpsCounted.ToString();
        }
        
    }

}
