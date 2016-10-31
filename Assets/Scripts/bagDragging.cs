using UnityEngine;
using System.Collections;

public class bagDragging : MonoBehaviour
{
    //mouse position:
    Vector2 mouseWorldPosition = Vector2.zero;
    
    //Is the bag dragging:
    public bool isDragging = false;

    bool isLocking = false;

    // Use this for initialization
    void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        
        mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(mouseWorldPosition, Vector2.zero);

        if (hit.collider != null && Input.GetMouseButtonDown(0) && hit.collider.name == this.gameObject.name)
        {
            isLocking = true;
        }
        else if(hit.collider == null || Input.GetMouseButtonUp(0))
        {
            isLocking = false;
        }

       
        if(isLocking == true && hit.collider.name == this.gameObject.name)
        {
            isDragging = true;
        }
        else
        {
            isDragging = false;
        }
        
    }
}
