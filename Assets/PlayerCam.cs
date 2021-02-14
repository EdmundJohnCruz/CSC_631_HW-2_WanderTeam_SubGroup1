using UnityEngine;
using System.Collections;

public class PlayerCam : MonoBehaviour
{
    public Transform player; //gets coord information of player into a variable
    public Vector3 offsetP; //offset for the back camera on the player
    public Quaternion offsetR; //offset rotation for back camera
    public Vector3 topDownP; //topdown position of camera
    public Quaternion topDownR; //topdown rotation of camera
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
            transform.position = topDownP;
            transform.rotation = topDownR;
        }

        if(switchPers == true)
        {
            transform.position = player.position + offsetP; //behind the player view
            transform.rotation = offsetR;
        }
    }
}
