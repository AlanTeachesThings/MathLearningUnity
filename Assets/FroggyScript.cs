using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FroggyScript : MonoBehaviour
{

    private Rigidbody2D r;
    private ValueHandlerScript v;

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody2D>();
        v = GameObject.Find("ValueHandler").GetComponent<ValueHandlerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Jump()
    {
        r.gravityScale = v.gravityScale;
        //Debug.Log("Jumping!");
        r.AddForce(new Vector3(v.horizontalForce, v.verticalForce, 0), ForceMode2D.Impulse);
    }
}
