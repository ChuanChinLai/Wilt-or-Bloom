using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour
{

    void update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        { 
            
            if (Application.platform == RuntimePlatform.Android)
            {
                Application.Quit();
            }
        }
    }



    public void LoadLevel(string name)
    {
        SceneManager.LoadScene(name);
//        Application.LoadLevel(name);
    }

    public void ExitRequest()
    {
        Application.Quit();
    }
}
