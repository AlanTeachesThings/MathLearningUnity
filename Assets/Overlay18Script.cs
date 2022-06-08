using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overlay18Script : MonoBehaviour
{
    public GameObject FroggyObject;
    public int frame;
    
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
        StartCoroutine(DelayedFroggyJump());
    }

    IEnumerator DelayedFroggyJump()
    {
        yield return new WaitForSeconds(1);
        GameObject.Find("Froggy").SendMessage("DrawAnimJump", frame);
    }
}
