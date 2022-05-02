using UnityEngine;

public class CameraFollowing : MonoBehaviour
{
  //variables for class
    public Transform player;
    public Vector3 offset;

      //checks every frame for movement
     void Update () 
    {
      //moves the camera to the center of the player sprite
      transform.position = new Vector3 (player.position.x + offset.x, player.position.y + offset.y, offset.z);
    }
}
