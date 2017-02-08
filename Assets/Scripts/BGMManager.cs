using UnityEngine;
using System.Collections;

public class BGMManager : MonoBehaviour 
{

    public AudioClip _AudioClip_day;
    public AudioClip _AudioClip_night;

    AudioSource _AudioSource;


	// Use this for initialization
	void Start () 
    {
        _AudioSource = GetComponent<AudioSource>();
        _AudioSource.clip = _AudioClip_day;
        _AudioSource.Play();
	}
	
	// Update is called once per frame
	void Update () 
    {
        
	}


    public void musicTransition()
    {
        if (_AudioSource.clip == _AudioClip_day)
        {
            _AudioSource.clip = _AudioClip_night;
            _AudioSource.Play();
        }
        else
        {
            _AudioSource.clip = _AudioClip_day;
            _AudioSource.Play();
        }
    }
        
}
