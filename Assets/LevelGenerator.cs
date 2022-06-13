using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{

    private float platformSpacing = 12f;
    private List<GameObject> platforms;
    private List<GameObject> hazards;
    public GameObject platformPrefab;
    public GameObject hazardPrefab;
    public GameObject icyPlatformPrefab;
    public GameObject bouncyPlatformPrefab;
    public bool spawnHazard;
    public bool spawnAltPlatforms = false;
    
    // Start is called before the first frame update
    void Start()
    {
        //GameObject.Find("Island_2").GetComponent<PlatformChecker>().generator = this;
        //Debug.Log("Level Manager Starting up!");
        platforms = new List<GameObject>();
        hazards = new List<GameObject>();
        SpawnPlatform(0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnPlatform(float horizontalOffset)
    {
        GameObject platformToUse = platformPrefab;
        float randomFloat = Random.value;
        //Debug.Log(spawnAltPlatforms);
        if((spawnAltPlatforms)&&(randomFloat > 0.5f))
        {
            if (randomFloat > 0.75f)
            {
                platformToUse = icyPlatformPrefab;
            }
            else
            {
                platformToUse = bouncyPlatformPrefab;
            }
        }
        GameObject newPlatform = GameObject.Instantiate(platformToUse, new Vector3(platformSpacing + (platformSpacing * (float)platforms.Count) + 6f - horizontalOffset, -2.5f, 0f), Quaternion.identity);
        platforms.Add(newPlatform);

        if (spawnHazard)
        {
            GameObject newHazard = GameObject.Instantiate(hazardPrefab, new Vector3(platformSpacing + (platformSpacing * (float)platforms.Count) - 12f - horizontalOffset, 0f, 0f), Quaternion.identity);
            hazards.Add(newHazard);
        }
        
    }

    public void Reset()
    { 
        foreach(GameObject platform in platforms)
        {
            //Debug.Log("Destroying Platform" + platform);
            Destroy(platform);
        }
        platforms = new List<GameObject>();
        foreach (GameObject hazard in hazards)
        {
            //Debug.Log("Destroying Platform" + platform);
            Destroy(hazard);
        }
        hazards = new List<GameObject>();
        SpawnPlatform(0f);
    }

    public void FrogLanded(float horizontalOffset)
    {
        //Debug.Log(horizontalOffset);
        SpawnPlatform(horizontalOffset);
    }
}
