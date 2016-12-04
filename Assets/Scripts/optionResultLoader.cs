using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class optionResultLoader : optionLoader 
{
    optionsBase optionbase;
    Text context;

    // Use this for initialization
    void Start ()
    {
        optionbase = optionObject.GetComponent<optionsBase>();
        context = this.GetComponent<Text>();
    }

    // Update is called once per frame
    public override void updateText()
    {
        context.text = optionbase.options[getParameters().day][getParameters().playerAnswer[getParameters().day]];
    }
}
