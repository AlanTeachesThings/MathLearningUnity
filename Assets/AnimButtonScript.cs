using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimButtonScript : MonoBehaviour
{
    public int animFrame;
    public float yPosition;
    public float upOrDown;

    // Start is called before the first frame update
    void Start()
    {
        transform.Find("Text").GetComponent<Text>().text = "X:"+(transform.position.x - 130).ToString("#")+", Y:"+ (transform.position.y-210).ToString("#");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateAnim()
    {
        GameObject.Find("ValueHandler").GetComponent<ValueHandlerScript>().animHeights[animFrame].y = yPosition;
        GameObject.Find("ValueHandler").GetComponent<ValueHandlerScript>().animHeights[animFrame].x = upOrDown;
        GameObject.Find("Froggy").SendMessage("ResetThenJump", animFrame);
    }
}
