using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChooseCharacter : MonoBehaviour {

    [SerializeField] public GameObject player1character;
    [SerializeField] public GameObject player2character;
    public static ChooseCharacter instance;
    void Awake()
    {
       DontDestroyOnLoad(gameObject);
        if (instance ==  null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            return;
        }
        Destroy(this.gameObject);
        
    }
    // Use this for initialization
    void Start ()
    {

        //Makes it so this gameObject / script doesnt destroy between scenes
        //Makes it able to transport data between different scenes (Menu -> World 1)
	}
	
	// Update is called once per frame
	void Update ()
    {
      
    }

    public void selectCharacter1(GameObject character1)
    {
        //Needs to store a reference to the player 1's selected character
        //Must be called on confirmation of character 1 selection
        player1character = character1;
        character1.tag = "Player";
    }
    public void selectCharacter2(GameObject character2)
    {
        //Ditto player 2
        player2character = character2;
        character2.tag = "Player2";
    }

    public void spawnCharacters()
    {
        //Spawns the player characters at (0,0) (You can change later)
        //Needs to be called once the gameplay scene happens (World1)
        Instantiate(player1character);
        Instantiate(player2character);
    }

}
