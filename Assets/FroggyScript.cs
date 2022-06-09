using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FroggyScript : MonoBehaviour
{

    private Rigidbody2D r;
    private ValueHandlerScript v;
    private bool draw = false;
    private bool animDraw = false;
    private float elapsedTime = 1f;
    private float interval;
    private int animFrame;
    private List<GameObject> drawObjects;
    private Camera c;

    public GameObject FroggyObject;
    public GameObject drawObject;
    public GameObject animDrawObject;

    public Sprite[] sprites;
    public Sprite landedSprite;

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody2D>();
        v = GameObject.Find("ValueHandler").GetComponent<ValueHandlerScript>();
        c = GameObject.Find("Main Camera").GetComponent<Camera>();
        drawObjects = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        //Handle animation frames
        if (r.velocity.magnitude > 0.75)
        {
            for (int i = 0; i < v.animHeights.Length; i++)
            {
                if (v.animHeights[i].x == GameObject.Find("Froggy").GetComponent<FroggyScript>().UpOrDown())
                {
                    if ((transform.position.y > v.animHeights[i].y)&&(v.animHeights[i].x == 1))
                    {
                        GetComponent<SpriteRenderer>().sprite = sprites[i];
                    }
                    if ((transform.position.y < v.animHeights[i].y) && (v.animHeights[i].x == -1))
                    {
                        GetComponent<SpriteRenderer>().sprite = sprites[i];
                    }
                }
            }
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = landedSprite;
        }

        // Handle drawing (if necessary)
        if (draw)
        {
            if (animDraw)
            {
                interval = 0.15f;
                //elapsedTime = 1f;
            }
            else
            {
                interval = 0.15f;
            }
            if (r.velocity.magnitude > 0)
            {
                elapsedTime += Time.deltaTime;
                //Debug.Log(elapsedTime);
                if (elapsedTime > interval)
                {
                    if (!animDraw)
                    {
                        var newDrawObject = GameObject.Instantiate(drawObject, transform.position - new Vector3(0.5f, 0.5f, 0f), Quaternion.identity);
                        var drawPosition = c.WorldToScreenPoint(transform.position);
                        newDrawObject.transform.Find("Canvas").transform.Find("Circle").GetComponent<RectTransform>().anchoredPosition = new Vector2(drawPosition.x, drawPosition.y - 25);
                        newDrawObject.transform.Find("Canvas").transform.Find("Circle").transform.Find("Text").GetComponent<Text>().text = "X:" + (drawPosition.x -130).ToString("#") + " Y:" + (drawPosition.y-210).ToString("#");
                        drawObjects.Add(newDrawObject);
                    }
                    else
                    {
                        var newAnimButton = GameObject.Instantiate(animDrawObject, transform.position - new Vector3(0.5f, 0.5f, 0f), Quaternion.identity);
                        drawObjects.Add(newAnimButton);
                        var drawPosition = c.WorldToScreenPoint(transform.position);
                        newAnimButton.transform.Find("Canvas").transform.Find("Button").GetComponent<RectTransform>().anchoredPosition = new Vector2(drawPosition.x, drawPosition.y-25);
                        newAnimButton.transform.Find("Canvas").transform.Find("Button").GetComponent<AnimButtonScript>().animFrame = animFrame;
                        newAnimButton.transform.Find("Canvas").transform.Find("Button").GetComponent<AnimButtonScript>().yPosition = transform.position.y;
                        newAnimButton.transform.Find("Canvas").transform.Find("Button").GetComponent<AnimButtonScript>().upOrDown = UpOrDown();
                    }
                    elapsedTime = 0f;
                }
            }
            else
            {
                //Debug.Log("Should be standing still now");
                draw=false;
            }
        }
        
    }

    public void Jump()
    {
        if (Mathf.Abs(r.velocity.y) < 0.5)
        {
            draw = false;
            r.gravityScale = v.gravityScale;
            //Debug.Log("Jumping!");
            r.AddForce(new Vector3(v.horizontalForce, v.verticalForce, 0), ForceMode2D.Impulse);
        }
    }

    public void DrawJump()
    {
        if (Mathf.Abs(r.velocity.y) < 0.5)
        {
            draw = true;
            r.gravityScale = v.gravityScale;
            //Debug.Log("Jumping!");
            r.AddForce(new Vector3(v.horizontalForce, v.verticalForce, 0), ForceMode2D.Impulse);
        }
    }

    public void DrawAnimJump(int frameToDraw)
    {
        if (Mathf.Abs(r.velocity.y) < 0.5)
        {
            animDraw = true;
            animFrame = frameToDraw;
            DrawJump();
        }
    }

    public void Reset()
    {
        foreach (var drawObject in drawObjects)
        {
            GameObject.Destroy(drawObject.gameObject);
        }
        var newFroggy = GameObject.Instantiate(FroggyObject, new Vector3(-5.39f, -0.445f, 0f), Quaternion.identity);
        newFroggy.name = "Froggy";
        newFroggy.GetComponent<Rigidbody2D>().WakeUp();
        GameObject.Destroy(this.gameObject);
    }

    public void ResetThenJump(int frametoDraw)
    {
        foreach (var drawObject in drawObjects)
        {
            GameObject.Destroy(drawObject.gameObject);
        }
        var newFroggy = GameObject.Instantiate(FroggyObject, new Vector3(-5.39f, -0.445f, 0f), Quaternion.identity);
        newFroggy.name = "Froggy";
        newFroggy.GetComponent<Rigidbody2D>().WakeUp();
        newFroggy.SendMessage("JumpWithDelay", frametoDraw);
        GameObject.Destroy(this.gameObject);
    }

    public void JumpWithDelay(int frameToDraw)
    {
        StartCoroutine(DelayedJump(frameToDraw));
    }

    IEnumerator DelayedJump(int frameToDraw)
    {
        yield return new WaitForSeconds(2);
        DrawAnimJump(frameToDraw);
    }

    public float UpOrDown()
    {
        if(r.velocity.y > 0)
        {
            return 1f;
        }
        else
        {
            return -1f;
        }
    }
}
