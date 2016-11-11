using UnityEngine;
using System.Collections;

public class watercanState : MonoBehaviour
{
    //rotation speed
    float turnSpeed = 50f;

    //init position:
    Vector3 initPosition = Vector3.zero;

    //mouse position:
    Vector2 mouseWorldPosition = Vector2.zero;

    //game parameters:
    public GameObject parameterObject;
    gameParameters parameters;

    // Use this for initialization
    void Start ()
    {
        initPosition = transform.position;
        parameters = parameterObject.GetComponent<gameParameters>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (this.GetComponent<objDragging>().isDragging == true && parameters.waterReady == false)
        {
            this.transform.position = mouseWorldPosition;
        }
        else
        {
            transform.position = initPosition;
        }

        if (this.GetComponent<bagCollision>().isColliding == true && parameters.waterReady == false && parameters.fertilizerReady == true && Input.GetMouseButtonUp(0))
        {
            StartCoroutine(rotate());
        }

    }

    IEnumerator rotate()
    {
        //rotate 2 seconds
        for (float i = 0; i <= 1.2; i += Time.deltaTime)
        {
            transform.position = new Vector3(3.5f, 0, 0);
            transform.Rotate(Vector3.forward, turnSpeed * Time.deltaTime);
            yield return 0;
        }

        parameters.waterReady = true;
        transform.rotation = Quaternion.identity;
        this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.5f);
    }
}
