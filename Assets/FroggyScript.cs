using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FroggyScript : MonoBehaviour
{

    private Rigidbody2D r;
    private ValueHandlerScript v;
    private bool draw = false;
    private bool animDraw = false;
    private float elapsedTime;
    private float interval;
    private List<GameObject> drawObjects;
    private Camera c;

    public GameObject drawObject;
    public GameObject animDrawObject;

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody2D>();
        v = GameObject.Find("ValueHandler").GetComponent<ValueHandlerScript>();
        c = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (draw)
        {
            drawObjects = new List<GameObject>();
            interval = 0.05f;
            if (r.velocity.magnitude > 0)
            {
                elapsedTime += Time.deltaTime;
                Debug.Log(elapsedTime);
                if (elapsedTime > interval)
                {
                    if (!animDraw)
                    {
                        drawObjects.Add(GameObject.Instantiate(drawObject, transform.position - new Vector3(0.5f, 0.5f, 0f), Quaternion.identity));
                    }
                    else
                    {
                        
                    }
                    elapsedTime = 0f;
                }
            }
            else
            {
                Debug.Log("Should be standing still now");
                draw=false;
            }
        }
        
    }

    public void Jump()
    {
        draw = false;
        r.gravityScale = v.gravityScale;
        //Debug.Log("Jumping!");
        r.AddForce(new Vector3(v.horizontalForce, v.verticalForce, 0), ForceMode2D.Impulse);
    }

    public void DrawJump()
    {
        draw = true;
        r.gravityScale = v.gravityScale;
        //Debug.Log("Jumping!");
        r.AddForce(new Vector3(v.horizontalForce, v.verticalForce, 0), ForceMode2D.Impulse);
    }

    public void DrawAnimJump()
    {
        animDraw = true;
        DrawJump();
    }
}
