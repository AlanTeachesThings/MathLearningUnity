using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MakeFroggyJump()
    {
        GameObject.Find("Froggy").SendMessage("Jump");
    }
}
