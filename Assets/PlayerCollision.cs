using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement; //creates a variable for the movement script to be utilized within this variable
    
    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("Obstacle Hit.");
            movement.enabled = false; //movement gets disabled
            transform.GetComponent<Renderer>().material.color = Color.white; //player turns white when colliding with the obstacle
        }
    }
}
