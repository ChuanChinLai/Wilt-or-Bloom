using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{

    public AudioClip _AudioClip;

    AudioSource _AudioSource;

    // Use this for initialization
    void Start ()
    {
        _AudioSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void playOnce()
    {
        _AudioSource.PlayOneShot(_AudioClip, 10.0f);
    }
}
