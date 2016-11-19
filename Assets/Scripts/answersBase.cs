using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class answersBase : MonoBehaviour 
{
    public List<int> bestAnswer = new List<int>();
    public List<int> worstAnswer = new List<int>();


	// Use this for initialization
	void Start ()
    {
        //Day 1: 
        bestAnswer.Add(1);
        worstAnswer.Add(0);
	}
	
	// Update is called once per frame
	void Update ()
    {

	}
        
}
