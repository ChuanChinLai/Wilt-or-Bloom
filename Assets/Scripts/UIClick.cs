using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIClick : MonoBehaviour
{
    public GameObject question;
    public GameObject popWindow;
    public GameObject nightMask;
    public GameObject m_INFO;


    public bool Isclicked = false;

    // Use this for initialization
    void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        if (popWindow.activeSelf == true && m_INFO.activeSelf == true)
        {
            m_INFO.SetActive(false);

        }
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

        popWindow.transform.GetChild(1).gameObject.SetActive(true);
        popWindow.transform.GetChild(2).gameObject.SetActive(true);
        popWindow.transform.GetChild(3).gameObject.SetActive(true);
        popWindow.transform.GetChild(4).gameObject.SetActive(true);

        popWindow.transform.GetChild(5).gameObject.SetActive(false);
    }

    public void displayQuestion(GameObject iObject)
    {
        if(popWindow.activeSelf == false)
        {
            popWindow.SetActive(true);
            question.SetActive(false);

            popWindow.transform.GetChild(5).gameObject.SetActive(true);
            popWindow.transform.GetChild(5).gameObject.GetComponent<Text>().text = iObject.GetComponent<Text>().text;


            popWindow.transform.GetChild(1).gameObject.SetActive(false);
            popWindow.transform.GetChild(2).gameObject.SetActive(false);
            popWindow.transform.GetChild(3).gameObject.SetActive(false);
            popWindow.transform.GetChild(4).gameObject.SetActive(false);
        }
        else
        {
            closeWindow();
        }
    }



    public void closeWindow()
    {
        popWindow.SetActive(false);
        question.SetActive(true);
        m_INFO.SetActive(true);
    }
        
}
