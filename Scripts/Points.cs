using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    int _playerPoints;
    int _player2Points;
    public Text player1Score;
    public Text player2Score;
    public Points instance;
    public bool World1 = false;
    public bool World2 = false;
    public bool World3 = false;

    void Awake()
    {
        //instance = this;
    }

    void Start()
    {
        Debug.Log("");
        playerPoints = 0;
        player2Points = 0;
    }

    void Update()
    {
        //Debug.Log(playerPoints);
        //if (World1 == true)
        //{
        //    player1Score = GameObject.Find("Player1Score").GetComponent<Text>();
        //    player2Score = GameObject.Find("Player2Score").GetComponent<Text>();
        //}

        //if (World2 == true)
        //{
        //    player1Score = GameObject.Find("Player1Score").GetComponent<Text>();
        //    player2Score = GameObject.Find("Player2Score").GetComponent<Text>();
        //}
        
        //if (World3 == true)
        //{
        //    player1Score = GameObject.Find("Player1Score").GetComponent<Text>();
        //    player2Score = GameObject.Find("Player2Score").GetComponent<Text>();
        //}
    }

    public int playerPoints
    {
        get
        {
            return _playerPoints;
        }
        set
        {
            _playerPoints = value;
            if (player1Score)
                player1Score.text = "Player 1 Score: " + playerPoints;
        }
    }
    public int player2Points
    {
        get
        {
            return _player2Points;
        }
        set
        {
            _player2Points = value;
            if (player2Score)
                player2Score.text = "Player 2 Score: " + player2Points;
        }
    }
}
