using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    //public Transform platformGenerator;
    //private Vector3 platformStartPoint;

    public PlayerController thePlayer;
    private Vector3 playerStartPoint;
    // Start is called before the first frame update
    void Start()
    {
        playerStartPoint = thePlayer.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RestartGame()
    {
        StartCoroutine("RestartGameCo");
    }
    public IEnumerator RestartGameCo()
    {
        //thePlayer.gameObject.SetActive(false);
        yield return new WaitForSeconds(1f);
        thePlayer.transform.position = playerStartPoint;
    }
}
