using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinishLine : MonoBehaviour
{
    public static FinishLine instance;
    public static FinishLine instance2;
    public int point;

    Points pointScript;

    void Awake()
    {
        instance = this;
        pointScript = GameObject.FindGameObjectWithTag("Points").GetComponent<Points>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            Debug.Log("Player Point");
            pointScript.playerPoints+=1;
            Debug.Log(pointScript.playerPoints);
            SceneManager.LoadScene("CharacterSelection");
        }

        if (collision.name == "Player2")
        {
            Debug.Log("Player 2 point");
            pointScript.player2Points+=1;
            SceneManager.LoadScene("CharacterSelection");
        }
    }


}
