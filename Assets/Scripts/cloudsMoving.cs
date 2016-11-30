using UnityEngine;
using System.Collections;

public class cloudsMoving : MonoBehaviour 
{

    public float velocity = 0.2f;

    Vector3 initPosition;


	// Use this for initialization
	void Start () 
    {
        initPosition = this.gameObject.transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () 
    {
        this.gameObject.transform.Translate(velocity * Vector3.left * Time.deltaTime);

        if (this.gameObject.transform.localPosition.x <= -20.0)
        {
            this.gameObject.transform.localPosition = initPosition;
        }
	}
}
