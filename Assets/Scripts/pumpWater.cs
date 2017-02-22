using UnityEngine;
using System.Collections;

public class pumpWater : MonoBehaviour
{
    Animator animator;
    Vector2 mouseWorldPosition = Vector2.zero;

    public GameObject waterObject;
    ParticleSystem water;


    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        water = waterObject.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(mouseWorldPosition, Vector2.zero);

        if (hit.collider != null && Input.GetMouseButtonDown(0) && hit.collider.name == this.gameObject.name)
        {
            //           Instantiate(water, new Vector2(6.68f, -0.8f), Quaternion.identity);

            GetComponent<Sound>().playOnce();
            if (animator.GetBool("play") == false)
            {
                animator.SetBool("play", true);
                StartCoroutine(waterDisplay());
            }

            if (animator.GetBool("ready") == false)
            {
                animator.SetBool("ready", true);
                StartCoroutine(waterDisplay());
                StartCoroutine(reset());
            }
            
        }
    }

    IEnumerator reset()
    {
        
        yield return new WaitForSeconds(0.7f);
        animator.SetBool("ready", false);
    }

    IEnumerator waterDisplay()
    {
        yield return new WaitForSeconds(0.5f);
        water.Play();
    }

}
