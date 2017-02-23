using UnityEngine;
using System.Collections;

public class UIDisplay : MonoBehaviour
{
    //game parameters:
    public GameObject parameterObject;
    gameParameters parameters;

    //UI Objects
    public GameObject INFO;
    public GameObject NEXT_DAY;

    public bool displayed = false;

    // Use this for initialization
    void Start ()
    {
        parameters = parameterObject.GetComponent<gameParameters>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(displayed == false)
        {
            display();
        }
    }


    void display()
    {
        if (parameters.fertilizerReady || true && parameters.waterReady || true)
        {
            INFO.SetActive(false);
            NEXT_DAY.SetActive(false);
        }
        if (parameters.fertilizerReady == true && parameters.waterReady == true)
        {
            INFO.SetActive(true);
            NEXT_DAY.SetActive(true);
            displayed = true;
        }
    }

}
