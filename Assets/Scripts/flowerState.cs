using UnityEngine;
using System.Collections;

public class flowerState : MonoBehaviour 
{

    private int state = 2;

    //Flower sprite: 
    public Sprite [] flowerSprites;

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
                    state += 1;
                    Debug.Log("BEST");
                }
                else if (parameters.playerAnswer[parameters.day] == answerbase.worstAnswer[parameters.day])
                {
                    state -= 1;
                    Debug.Log("WORSE");
                }

                GetComponent<SpriteRenderer>().sprite = flowerSprites[state];
            }
        }

    }
}
