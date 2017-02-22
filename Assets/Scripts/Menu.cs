using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject m_Menu;
    public GameObject m_Question;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void onClick()
    {
        if(m_Menu.activeSelf == true)
        {
            m_Menu.SetActive(false);
            m_Question.SetActive(true);
        }
        else
        {
            m_Menu.SetActive(true);
            m_Question.SetActive(false);
        }
    }

}
