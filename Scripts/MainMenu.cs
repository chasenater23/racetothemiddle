using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGameBtn(string nextLevel) 
    {
        //Load next scene
        SceneManager.LoadScene("CharacterSelection");
    }

    public void ExitGameBtn()
    {
        Debug.Log("Game has quit");
        //Quit button will close the application
        Application.Quit();
    }

    public void HowToPlayGameBtn()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
