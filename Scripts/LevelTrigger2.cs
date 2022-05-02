using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTrigger2 : MonoBehaviour
{   
    //vairables used in code
    public Transform wall2;
    public Transform wall3;
    public Transform wall4;

    private bool isMove = false;
    public float moveSpeed = 10f;
    [SerializeField] private Rigidbody2D rb;

    //checks tp see if isMove has been changed to true periodically
    private void FixedUpdate()
    {
        if(isMove)
        {
            //Debug for testing, translate used to move the object out of the way to allow progression
            //Debug.Log ("Moved");
            wall2.Translate (100,100,0);
            wall3.Translate (100,100,0);
            wall4.Translate (100,100,0);
        }
        else
        {
            //Debug.Log ("Don't Move");
        }
    }

    //changes isMove to true when player collides with the interactable
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("trigger2"))
        {
            isMove = true;
        }
    }
}


