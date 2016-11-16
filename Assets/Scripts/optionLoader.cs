using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class optionLoader : MonoBehaviour
{
    public GameObject optionObject;
    optionsBase optionbase;

    public int day;
    public int index;
    Text context;

    // Use this for initialization
    public void Start ()
    {
        optionbase = optionObject.GetComponent<optionsBase>();
        context = this.GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        updateText();
	}

    public virtual void updateText()
    {
        context.text = optionbase.options[day][index];
    }

}
