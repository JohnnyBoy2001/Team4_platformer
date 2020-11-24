using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void ButtonLevel1()
    {
        SceneManager.LoadScene(1);
    }
    
    public void ButtonLevel2()
    {
        SceneManager.LoadScene(2);
    }

    public void ButtonLevel3()
    {
        SceneManager.LoadScene(3);
    }

    public void ButtonLevel4()
    {
        SceneManager.LoadScene(4);
    }

    public void ButtonLevel5()
    {
        SceneManager.LoadScene(5);
    }
}

