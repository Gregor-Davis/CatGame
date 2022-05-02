using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    //function that changes the scene to the main game when Play button is pressed
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //function that will close the application when the quit button is pressed
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    //function that is used on the back button in the Controls scene to go back to the menu screen
    public void BackButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    //function that is used on the controls button to go to the controls scene
    public void ControlButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
}
