using UnityEngine;
using System.Collections;

public class bagState : MonoBehaviour
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

    //Fertilizer
    public GameObject fertilizerObject;
    ParticleSystem fertilizer;

    // Use this for initialization
    void Start ()
    {
        initPosition = transform.position;
        fertilizer = fertilizerObject.GetComponent<ParticleSystem>();
        parameters = parameterObject.GetComponent<gameParameters>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (this.GetComponent<objDragging>().isDragging == true && parameters.fertilizerReady == false)
        {
            this.transform.position = mouseWorldPosition;
        }
        else
        {
            transform.position = initPosition;
        }

        if(this.GetComponent<bagCollision>().isColliding == true && parameters.fertilizerReady == false && Input.GetMouseButtonUp(0))
        {
            StartCoroutine(rotate());
        }
    }

    IEnumerator rotate()
    {
        //rotate 2 seconds
        for(float i = 0; i <= 2.0f; i += Time.deltaTime)
        {
            transform.position = new Vector3(-2.7f, 1.0f, 0);

            if (i >= 1.0f)
            {
                fertilizerObject.transform.localPosition = new Vector3(-1.5f, 1.3f, -2.0f);

                if (!fertilizerObject.GetComponent<AudioSource>().isPlaying)
                {
                    fertilizerObject.GetComponent<Sound>().playOnce();
                }

                fertilizer.Play();
            }
                
            transform.Rotate(Vector3.back, turnSpeed * Time.deltaTime);
            yield return 0;
        }

        parameters.fertilizerReady = true;
        parameters.setAnswers(this.gameObject.name);

        transform.rotation = Quaternion.identity;

        fertilizerObject.transform.localPosition = new Vector3(-25.0f, 1.5f, -2.0f);
        this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.5f);
    }

    public void initState()
    {
        this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
    }

}
