﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class gameParameters : MonoBehaviour
{
    //game parameters
    public int day = 0;
    int day_MAX = 7;

    public bool fertilizerReady = false;
    public bool waterReady = false;
    public bool flowerUpdated = false;

    //player's answer
    public List<int> playerAnswer = new List<int>();

	// Use this for initialization
	void Start ()
    {
	
	}

    // Update is called once per frame
    void Update()
    {

    }

    public void ResetEverything()
    {
        day = 0;
        playerAnswer = new List<int>();
    }

    public void gotoNextDay()
    {
        fertilizerReady = false;
        waterReady = false;
        flowerUpdated = false;

        day += 1;

        if (day == day_MAX)
        {
            SceneManager.LoadScene("Resource");
        }
    }


    public void setAnswers(string objectName)
    {
        switch (objectName)
        {
            case "blue bag":
                playerAnswer.Add(0);
                break;

            case "green bag":
                playerAnswer.Add(1);
                break;

            case "purple bag":
                playerAnswer.Add(2);
                break;
        }
    }

}
