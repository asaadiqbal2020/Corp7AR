using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Actions: MonoBehaviour
{
    public void doQuit ()
    {
        Debug.Log("The application has been terminated.");
        Application.Quit();
    }
    public void doReload()
    {
        SceneManager.LoadScene(0);
    }
}
