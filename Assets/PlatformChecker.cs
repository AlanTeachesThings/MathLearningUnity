using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformChecker : MonoBehaviour
{

    public LevelGenerator generator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTrigger2DEnter(Collision2D other)
    {
        Debug.Log(generator);
        if(generator != null)
        {
            //generator.SpawnPlatform();
        }
    }
}
