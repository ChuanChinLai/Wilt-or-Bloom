﻿using UnityEngine;
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
        bestAnswer.Add(0);
        worstAnswer.Add(-1);

        //Day 2: 
        bestAnswer.Add(2);
        worstAnswer.Add(1);

        //Day 3: 
        bestAnswer.Add(1);
        worstAnswer.Add(2);

        //Day 4: 
        bestAnswer.Add(0);
        worstAnswer.Add(1);

        //Day 5: 
        bestAnswer.Add(2);
        worstAnswer.Add(-1);

        //Day 6: 
        bestAnswer.Add(1);
        worstAnswer.Add(0);

        //Day 7: 
        bestAnswer.Add(2);
        worstAnswer.Add(0);
    }
	
	// Update is called once per frame
	void Update ()
    {

	}
        
}
