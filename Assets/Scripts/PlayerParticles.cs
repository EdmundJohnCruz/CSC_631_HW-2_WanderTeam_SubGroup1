using UnityEngine;

public class PlayerParticles : MonoBehaviour
{

    public Transform player; //gets coord information of player into a variable

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position;
    }
}
