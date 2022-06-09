using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueHandlerScript : MonoBehaviour
{

    public float horizontalForce = 0;
    public float verticalForce = 0;
    public float gravityScale = 0;
    public Vector2[] animHeights;
    public float frequency = 0;
    public float amplitude = 0;
    public float icePlatformFriction = 2;
    public float bouncyPlatformBounciness = 0;

    public int jumpsCounted = 0;

    //private bool draw = false;
    //private bool animDraw = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
