using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overlay18Script : MonoBehaviour
{
    public GameObject FroggyObject;
    
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
        GameObject.Destroy(GameObject.Find("Froggy"));
        var newFroggy = GameObject.Instantiate(FroggyObject, new Vector3(-5.39f, 0f, 0f), Quaternion.identity);
        newFroggy.name = "Froggy";
        newFroggy.GetComponent<Rigidbody2D>().WakeUp();
        StartCoroutine(DelayedFroggyJump());
    }

    IEnumerator DelayedFroggyJump()
    {
        yield return new WaitForSeconds(1);
        GameObject.Find("Froggy").SendMessage("DrawAnimJump");
    }
}
