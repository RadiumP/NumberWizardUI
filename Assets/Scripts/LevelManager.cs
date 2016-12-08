using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void LoadNewLevel(string name)
    {
        Debug.Log("Level load requested" + name);
        //Application.LoadLevel(name);
        SceneManager.LoadScene(name);
    }

    public void QuitRequest()
    {
        Debug.Log("Quit requested");
        Application.Quit();//Limitations: Works great for pc and consoles but not debug and Web/Mobile, so not good
    }

    public void ReturnToMain()
    {
        string name = "Start";
        SceneManager.LoadScene(name);       
    }

}
