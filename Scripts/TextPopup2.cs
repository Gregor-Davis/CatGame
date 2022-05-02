using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextPopup2 : MonoBehaviour
{
    //variables available in the inspector to set the text to
    public GameObject UiObject2;
    [SerializeField] private Rigidbody2D rb;

    // Start is called before the first frame update to hide the text
    void Start()
    {
        UiObject2.SetActive(false);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("trigger4"))
        {
            //Set the text to show on screen
            //Debug.Log("TextPopup");
            UiObject2.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "trigger4")
        {
            //hide the text from the player
            //Debug.Log("Text remove");
            UiObject2.SetActive(false);
        }
    }
}
