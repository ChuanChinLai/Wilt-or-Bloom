using UnityEngine;
using System.Collections;

public class hyperLink : MonoBehaviour 
{
    public string url;

    public void openWeb()
    {
        Application.OpenURL(url);
    }

}
