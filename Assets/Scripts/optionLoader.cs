using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class optionLoader : MonoBehaviour
{
    public GameObject optionObject;
    optionsSystem optionsystem;

    public int day;
    public int index;

    Text context;
    // Use this for initialization
    void Start ()
    {
        optionsystem = optionObject.GetComponent<optionsSystem>();
        context = this.GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        context.text = optionsystem.options[day][index];
	}
}
