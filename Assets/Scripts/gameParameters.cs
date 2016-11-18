using UnityEngine;
using System.Collections;

public class gameParameters : MonoBehaviour
{
    //game parameters
    public int day = 0;

    public bool fertilizerReady = false;

    public bool waterReady = false;

	// Use this for initialization
	void Start ()
    {
	
	}

    // Update is called once per frame
    void Update()
    {
       
    }

    public void gotoNextDay()
    {
        fertilizerReady = false;
        waterReady = false;
        day += 1;
    }

}
