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

    //Good Feedback Object and Particle
    public GameObject Good_Feedback_Object;
    ParticleSystem Good_Feedback_Particle;

    //Bad Feedback Object and Particle
    public GameObject Bad_Feedback_Object;
    ParticleSystem Bad_Feedback_Particle;


	// Use this for initialization
	void Start () 
    {
        parameters = parameterObject.GetComponent<gameParameters>();
        answerbase = dialogueManager.GetComponent<answersBase>();

        Good_Feedback_Particle = Good_Feedback_Object.GetComponent<ParticleSystem>();
        Bad_Feedback_Particle = Bad_Feedback_Object.GetComponent<ParticleSystem>();
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
                    Good_Feedback_Particle.Play();

                    Debug.Log("BEST");
                }
                else if (parameters.playerAnswer[parameters.day] == answerbase.worstAnswer[parameters.day])
                {
                    state -= 1;
                    Bad_Feedback_Particle.Play();

                    Debug.Log("WORSE");
                }

                GetComponent<SpriteRenderer>().sprite = flowerSprites[state];
            }
        }

    }

    public void initState()
    {
        Good_Feedback_Particle.Stop();
        Bad_Feedback_Particle.Stop();
    }

}
