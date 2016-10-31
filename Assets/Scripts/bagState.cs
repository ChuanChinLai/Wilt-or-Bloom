using UnityEngine;
using System.Collections;

public class bagState : MonoBehaviour
{
    public float turnSpeed = 50f;

    //init position:
    Vector3 initPosition = Vector3.zero;

    //mouse position:
    Vector2 mouseWorldPosition = Vector2.zero;

    //Used???
    bool available = true;

    bagDragging Dragging;
    bagCollision Collision;

    // Use this for initialization
    void Start ()
    {
        initPosition = transform.position;
        Dragging = this.GetComponent<bagDragging>();
        Collision = this.GetComponent<bagCollision>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Dragging.isDragging == true && available == true)
        {
            this.transform.position = mouseWorldPosition;
        }
        else
        {
            transform.position = initPosition;
        }

        if(Collision.isColliding == true && Input.GetMouseButtonUp(0))
        {
            StartCoroutine(rotate());
        }


    }

    IEnumerator rotate()
    {
        //rotate 2 seconds
        for(float i = 0; i <= 2; i += Time.deltaTime)
        {
            transform.position = new Vector3(0, 0, 0);
            transform.Rotate(Vector3.back, turnSpeed * Time.deltaTime);
            yield return 0;
        }

        available = false;
        transform.rotation = Quaternion.identity;
        this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.5f);
    }
}
