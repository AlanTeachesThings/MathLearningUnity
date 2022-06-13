using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverlayScript3 : MonoBehaviour
{
    public GameObject advanceButton;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Activate()
    {
        GameObject.Find("Froggy").GetComponent<Rigidbody2D>().WakeUp();
        StartCoroutine(DelayedButtonReveal());
    }

    IEnumerator DelayedButtonReveal()
    {
        yield return new WaitForSeconds(1.5f);
        advanceButton.SetActive(true);
    }
}

