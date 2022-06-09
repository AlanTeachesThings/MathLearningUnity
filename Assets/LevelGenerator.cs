using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{

    private float platformSpacing = 12f;
    private List<GameObject> platforms;
    public GameObject platformPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        //GameObject.Find("Island_2").GetComponent<PlatformChecker>().generator = this;
        
        platforms = new List<GameObject>();
        SpawnPlatform(0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnPlatform(float horizontalOffset)
    {
        GameObject newPlatform = GameObject.Instantiate(platformPrefab, new Vector3(platformSpacing + (platformSpacing * (float)platforms.Count) + 6f - horizontalOffset, -2.5f, 0f), Quaternion.identity);
        //newPlatform.GetComponent<PlatformChecker>().generator = this;
        platforms.Add(newPlatform);
    }

    public void Reset()
    { 
        foreach(GameObject platform in platforms)
        {
            Destroy(platform);
        }
    }

    public void FrogLanded(float horizontalOffset)
    {
        //Debug.Log(horizontalOffset);
        SpawnPlatform(horizontalOffset);
    }
}
