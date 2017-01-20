using UnityEngine;
using System.Collections;

public class objDragging : MonoBehaviour
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

        if (hit.collider != null && hit.collider.name == this.gameObject.name && Input.GetMouseButtonDown(0))
        {
            isLocking = true;
        }
        else if(hit.collider == null || Input.GetMouseButtonUp(0))
        {
            isLocking = false;
        }
            
        if(isLocking == true)
        {
            isDragging = true;
        }
        else
        {
            isDragging = false;
        }
        
    }
}
