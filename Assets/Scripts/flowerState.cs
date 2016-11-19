using UnityEngine;
using System.Collections;

public class flowerState : MonoBehaviour 
{

    //game parameters:
    public GameObject parameterObject;
    gameParameters parameters;

    //answer base
    public GameObject dialogueManager;
    answersBase answerbase;

	// Use this for initialization
	void Start () 
    {
        parameters = parameterObject.GetComponent<gameParameters>();
        answerbase = dialogueManager.GetComponent<answersBase>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        updateState();
	}

    void updateState()
    {

        if (parameters.fertilizerReady == true && parameters.waterReady == true)
        {
            if (parameters.flowerUpdated == false)
            {
                parameters.flowerUpdated = true;

                if (parameters.playerAnswer[parameters.day] == answerbase.bestAnswer[parameters.day])
                {
                    Debug.Log("BEST");
                }
                else if (parameters.playerAnswer[parameters.day] == answerbase.worstAnswer[parameters.day])
                {
                    Debug.Log("WORSE");
                }
                
            }
        }

    }
        
}
