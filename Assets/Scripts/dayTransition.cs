using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class dayTransition : MonoBehaviour 
{

    //game parameters:
    public GameObject parameterObject;
    gameParameters parameters;

    //game BGM:
    public GameObject BGM_Ojects;
    BGMManager BGM_manager;

    //night mask image:
    Image image;

    // Use this for initialization
    void Start() 
    {
        image = GetComponent<Image>();
        BGM_manager = BGM_Ojects.GetComponent<BGMManager>();
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

        //music transition day->night 
        BGM_manager.musicTransition();

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

        //music transition night->day 
        BGM_manager.musicTransition();

        image.color = new Color(0.0f, 0.0f, 0.0f, 0.0f);
    }
        
}
