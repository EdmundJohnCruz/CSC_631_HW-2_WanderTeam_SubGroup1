using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb; //utilizes Rigid Body component as a variable

    public float forwardForce = 2000f; //force for moving forward and back
    public float sidewaysForce = 500f; //force for moving sideways

    void FixedUpdate() //fixed update for using physics stuff; called once per frame
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime); //adding force of 2000 on z-axis
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime); //adding force of -2000 on z-axis
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime,0, 0); //adding force of - on x-axis
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0); //adding force of -500 on x-axis
        }

    }
}
