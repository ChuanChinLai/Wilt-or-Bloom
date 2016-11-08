using UnityEngine;
using System.Collections;

public class clickIcon : MonoBehaviour
{
    public bool Isclicked = false;

    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {

    }

    public void clickInfo()
    {
        if(Isclicked == false)
        {
            Isclicked = true;
        }
        else
        {
            Isclicked = false;
        }
    }
}
