using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawBladeScript : MonoBehaviour
{
    public GameObject layer1;
    public GameObject layer2;
    public float spinSpeed;

    private float elapsedTime;
    private Vector3 spawnLocation;
    private ValueHandlerScript v;


    // Start is called before the first frame update
    void Start()
    {
        spawnLocation = transform.position;
        v = GameObject.Find("ValueHandler").GetComponent<ValueHandlerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(v.frequency);
        elapsedTime += Time.deltaTime;
        layer1.transform.Rotate(new Vector3(0f, 0f, 0.1f));
        layer2.transform.Rotate(new Vector3(0f, 0f, -0.1f));
        transform.position = spawnLocation + new Vector3(0f, Mathf.Sin(elapsedTime * v.frequency) * v.amplitude, 0f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Hit the sawblade");
        if (other.gameObject.name == "Froggy")
        {
            other.gameObject.SendMessage("Reset");
        }
    }
}
