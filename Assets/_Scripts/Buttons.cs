using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    /*
    This is a script for all of the buttons I use in my game.
    When setting up the button all you have to do is just choose which thing you want to do.
    */
    public GameObject creditsmenu;
    public GameObject instructionsmenu;

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level 1");
        Time.timeScale = 1.0f;
    
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1.0f;

    }
    public void LoadWinScreen() 
    {
        SceneManager.LoadScene("End_Screne");
        Time.timeScale = 1.0f;

    }
    public void Quitbutton()
    {
        Application.Quit();

    }
    public void Instructions()
    {
        instructionsmenu.SetActive(true);

    }
    public void credits()
    {
        creditsmenu.SetActive(true);

    }
}
