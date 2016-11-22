using UnityEngine;
using System.Collections;

public class UIClick : MonoBehaviour
{
    public GameObject question;
    public GameObject popWindow;
    public GameObject nightMask;


    public bool Isclicked = false;

    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        
    }

    void displayWindow()
    {
        if (Isclicked == true)
        {
            popWindow.SetActive(true);
        }
        else
        {
            popWindow.SetActive(false);
        }
    }


    public void clickInfo()
    {
        popWindow.SetActive(true);
        question.SetActive(false);
    }


    public void closeWindow()
    {
        popWindow.SetActive(false);
        question.SetActive(true);
    }
        
}
