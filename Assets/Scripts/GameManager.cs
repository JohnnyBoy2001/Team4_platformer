using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    //public Transform platformGenerator;
    //private Vector3 platformStartPoint;

    //public PlayerController thePlayer;
    //private Vector3 playerStartPoint;
    // Start is called before the first frame update

    bool gameHasEnded = false;
    public float deathTimeOut = 2f;
    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("RestartGame", deathTimeOut);
        }
    }


    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //Application.LoadLevel(SceneManager.GetActiveScene().name);
    }
    
}
