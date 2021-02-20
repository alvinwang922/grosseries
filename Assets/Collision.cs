using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    SpriteRenderer renderReference;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(UnityEngine.Collision collision)
    {
        //Output the Collider's GameObject's name
        Debug.Log(Collision.GetComponent<Collider>().name);
        renderReference.color = Color.green;
    }

    //If your GameObject keeps colliding with another GameObject with a Collider, do something
    void OnCollisionStay(UnityEngine.Collision collision)
    {
        Debug.Log(Collision.GetComponent<Collider>().name);
        renderReference.color = Color.green;
    }
}