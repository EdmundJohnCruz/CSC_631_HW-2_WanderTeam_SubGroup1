using UnityEngine;
using System.Collections;

public class PlayerCam : MonoBehaviour
{
    public Transform player; //gets coord information of player into a variable
    public Vector3 offset; //offset for the back camera on the player
    public Vector3 topDown;
    public bool switchPers = false;
    public float timeBetwQ = 0.500f; //allow half a second before pressing Q again
    public float timestamp;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("q") && Time.time >= timestamp)
        {
            timestamp = Time.time + timeBetwQ;
            switchPers = !switchPers; //switches between true and false
            Debug.Log(switchPers); //seeing what value is given in console
        }

        if(switchPers == false)
        {
            transform.position = topDown;
        }

        if(switchPers == true)
        {
            transform.position = player.position + offset; //behind the player view
        }
    }
}
