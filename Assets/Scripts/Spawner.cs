using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    Vector3 position;
    public GameObject obstacle;
    public float timeBetwS = 0.200f; //allow 0.2 seconds before spawning again
    public float timestamp;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && Time.time >= timestamp)
        {
            timestamp = Time.time + timeBetwS;
            Vector3 scenePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition, Camera.MonoOrStereoscopicEye.Mono); //position gets noted when
            //mouse is clicked

            Instantiate(obstacle).transform.position = position;
        }
    }
}
