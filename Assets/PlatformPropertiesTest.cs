using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformPropertiesTest : MonoBehaviour
{
    
    public GameObject iceIsland;
    public PhysicsMaterial2D icePlatformMaterial;

    private GameObject platform;
    private ValueHandlerScript v;
    private Rigidbody2D c;
    private CameraControlScript cam;

    // Start is called before the first frame update
    void Start()
    {
        platform = GameObject.Find("Island_2");
        var spawnLocation = platform.transform.position;
        Destroy(platform);
        platform = Instantiate(iceIsland, spawnLocation, Quaternion.identity);
        platform.name = "Island_2";
        c = platform.GetComponent<Rigidbody2D>();
        v = GameObject.Find("ValueHandler").GetComponent<ValueHandlerScript>();
        c.sharedMaterial = icePlatformMaterial;
        cam = GameObject.Find("Main Camera").GetComponent<CameraControlScript>();
        cam.Zoom(10f, new Vector3(5f,2f,-20f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdatePlatformFriction()
    {
        //Debug.Log("Platform Friction should be 0");
        icePlatformMaterial.friction = v.icePlatformFriction;
        c.sharedMaterial= icePlatformMaterial;
    }

    public void UpdatePlatformBounciness()
    {
        //Debug.Log("Platform Friction should be 0");
        icePlatformMaterial.bounciness = v.bouncyPlatformBounciness;
        c.sharedMaterial = icePlatformMaterial;
    }

}
