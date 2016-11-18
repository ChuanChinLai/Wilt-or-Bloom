using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class dayTransition : MonoBehaviour 
{
    // Use this for initialization
    Image image;

    void Start() 
    {
        image = GetComponent<Image>();
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

      

        for(float i = 0; i <= 2.5f; i += Time.deltaTime)
        {
            image.color = new Color(0.0f, 0.0f, 0.0f, (1.0f - i * 0.4f) );
            yield return 0;
        }

        image.color = new Color(0.0f, 0.0f, 0.0f, 0.0f);
       
    }
        
}
