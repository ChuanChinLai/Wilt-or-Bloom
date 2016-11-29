using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class dayTransition : MonoBehaviour 
{

    //game parameters:
    public GameObject parameterObject;
    gameParameters parameters;

    // Use this for initialization
    Image image;

    void Start() 
    {
        image = GetComponent<Image>();
        parameters = parameterObject.GetComponent<gameParameters>();
    }


	// Update is called once per frame
	void Update () 
    {
	
	}

    public void transition()
    {
        StartCoroutine(setAlpha() );
    }


    IEnumerator setAlpha()
    {
        
        for(float i = 0; i <= 2.5f; i += Time.deltaTime)
        {
            image.color = new Color(0.0f, 0.0f, 0.0f, i * 0.4f);
            yield return 0;
        }
            
        parameters.gotoNextDay();

        for(float i = 0; i <= 2.5f; i += Time.deltaTime)
        {
            image.color = new Color(0.0f, 0.0f, 0.0f, (1.0f - i * 0.4f) );
            yield return 0;
        }


        image.color = new Color(0.0f, 0.0f, 0.0f, 0.0f);
    }
        
}
