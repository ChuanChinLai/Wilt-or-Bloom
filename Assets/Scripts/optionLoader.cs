using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class optionLoader : MonoBehaviour
{
    public GameObject optionObject;
    protected optionsBase optionbase;

    //game parameters:
    public GameObject parameterObject;
    gameParameters parameters;

    public int index;
    protected Text context;

    void Awake()
    {
        parameters = parameterObject.GetComponent<gameParameters>();
        optionbase = optionObject.GetComponent<optionsBase>();
        context = this.GetComponent<Text>();
    }


    // Use this for initialization
    void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
        updateText();
	}
        
    public virtual void updateText()
    {
        context.text = optionbase.options[parameters.day][index];
    }

    public gameParameters getParameters()
    {
        return parameters;
    }
}
