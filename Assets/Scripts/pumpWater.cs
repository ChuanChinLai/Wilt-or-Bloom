using UnityEngine;
using System.Collections;

public class pumpWater : MonoBehaviour
{
    Animator animator;
    Vector2 mouseWorldPosition = Vector2.zero;

    public GameObject water;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(mouseWorldPosition, Vector2.zero);

        if (hit.collider != null && Input.GetMouseButtonDown(0) && hit.collider.name == this.gameObject.name)
        {
 //           Instantiate(water, new Vector2(6.68f, -0.8f), Quaternion.identity);

            if (animator.GetBool("play") == false)
            {
                animator.SetBool("play", true);
            }

            if (animator.GetBool("ready") == false)
            {
                animator.SetBool("ready", true);
                StartCoroutine(reset());
            }
            
        }
    }

    IEnumerator reset()
    {
        for (float i = 0; i <= 0.75; i += Time.deltaTime)
        {
            yield return 0;
        }

        animator.SetBool("ready", false);
    }
}
