using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class optionsBase : MonoBehaviour 
{
    //question, options and hints 
    //Example: options[day][option index];
    public List<string> questions = new List<string>();

    public List<List<string>> options = new List<List<string>>();
    public List<List<string>> hints = new List<List<string>>();

	// Use this for initialization
	void Start () 
    {
        //Day 1: 
        questions.Add("D1QQ");

        List<string> dailyOption = new List<string>();
        dailyOption.Add("D1O1");
        dailyOption.Add("D1O2");
        dailyOption.Add("D1O3");
        options.Add(dailyOption);

        List<string> dailyHint = new List<string>();
        dailyHint.Add("D1H1");
        dailyHint.Add("D1H2");
        dailyHint.Add("D1H3");
        hints.Add(dailyHint);

        //Day 2:
        questions.Add("D2QQ");

        dailyOption = new List<string>();
        dailyOption.Add("D2O1");
        dailyOption.Add("D2O2");
        dailyOption.Add("D2O3");
        options.Add(dailyOption);

        dailyHint = new List<string>();
        dailyHint.Add("D2H1");
        dailyHint.Add("D2H2");
        dailyHint.Add("D2H3");
        hints.Add(dailyHint);
	}
	
	// Update is called once per frame
	void Update () 
    {

	}
}
