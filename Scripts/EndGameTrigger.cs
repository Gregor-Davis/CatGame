using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndGameTrigger : MonoBehaviour
{
    //gets the players hitbox
    [SerializeField] private Rigidbody2D rb;

    //function that when the player enters the collision it runs the Back() function
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("trigger3"))
        {
            Back();
        }
    }

    //function that changes the game scene in the build settings back to the main menu
    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
    }
}
