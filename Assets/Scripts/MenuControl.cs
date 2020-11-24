using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    public void ButtonStart()
    {
        SceneManager.LoadScene(1);
    }

    public void ButtonLevel()
    {
        SceneManager.LoadScene(6);
    }

    public void ButtonQuit()
    {
        Application.Quit();
    }
}