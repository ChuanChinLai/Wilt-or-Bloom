using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class dayImgManager : MonoBehaviour 
{
    //game parameters:
    public GameObject parameterObject;
    gameParameters parameters;

    //Sprite
    public Sprite [] dailySprites;

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
        image.sprite = dailySprites[parameters.day];
	}

   
}
