using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    void OnEnable()
    {

        StartCoroutine(delay());
    }

    // Use this for initialization
    void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {

    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(0.1f);
        GetComponent<Sound>().playOnce();
        yield return new WaitForSeconds(3.0f);
        gameObject.SetActive(false);
    }
}
