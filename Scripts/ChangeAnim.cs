using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnim : MonoBehaviour
{
    //Sets variables in the inspector on unity
    public AnimatorOverrideController hatAnim;
    [SerializeField] private Rigidbody2D rb;

    //function that runs the HatAnimation() function when the player enters the collision box
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("HatTrigger"))
        {
            HatAnimation();
        }
    }

    //function that changes the animations of the player sprite to the cat with a tophat on from a normal cat
    public void HatAnimation()
    {
        GetComponent<Animator>().runtimeAnimatorController = hatAnim as RuntimeAnimatorController;
    }

}
