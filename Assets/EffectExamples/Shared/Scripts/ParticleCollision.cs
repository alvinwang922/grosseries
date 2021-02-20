using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    //If your GameObject starts to collide with another GameObject with a Collider
    void OnCollisionEnter(Collision collision)
    {
        //Output the Collider's GameObject's name
        Debug.Log(collision.GetComponent<Collider>().name);
        collision.GetComponent<Collider>().GetComponent<Renderer> ().material.color = Color.green;
    }

    //If your GameObject keeps colliding with another GameObject with a Collider, do something
    void OnCollisionStay(Collision collision)
    {
        Debug.Log(collision.GetComponent<Collider>().name);
        collision.GetComponent<Collider>().GetComponent<Renderer> ().material.color = Color.green;
    }
}
