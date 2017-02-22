using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class OpeningChange : MonoBehaviour
{
    public Sprite BGI;
    Image image;

    public GameObject start;
    public GameObject Resource;
    public GameObject Exit;


    bool isPlay = false;
    // Use this for initialization
    void Start()
    {
        image = gameObject.GetComponent<Image>();


    }

    // Update is called once per frame
    void Update()
    {
        if (isPlay == false)
        {
            isPlay = true;
            StartCoroutine(play());
        }

    }

    IEnumerator play()
    {
        float c = 0.0f;

        for (float i = 0; i <= 2.5f; i += Time.fixedDeltaTime)
        {
            image.color = new Color(c, c, c, 1.0f);
            c += 0.008f;
            yield return 0;
        }

        yield return new WaitForSeconds(1.5f);

        for (float i = 0; i <= 2.5f; i += Time.fixedDeltaTime)
        {
            image.color = new Color(c, c, c, 1.0f);
            c -= 0.008f;
            yield return 0;
        }

        yield return new WaitForSeconds(1.0f);
        image.sprite = BGI;

        for (float i = 0; i <= 2.5f; i += Time.fixedDeltaTime)
        {
            image.color = new Color(c, c, c, 1.0f);
            c += 0.008f;
            yield return 0;
        }

        start.SetActive(true);
        Resource.SetActive(true);
        Exit.SetActive(true);
    }
}