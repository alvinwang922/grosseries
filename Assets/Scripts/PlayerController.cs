using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.Debug.Log("TEST");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
    }
    void OnCollisionEnter(UnityEngine.Collision collision)
    {
        //Output the Collider's GameObject's name
        if (collision.gameObject.name == "Cube") {
            UnityEngine.Debug.Log("YAY");
            GetComponent<Renderer>().material.color = Color.green;
        }
    }

    //If your GameObject keeps colliding with another GameObject with a Collider, do something
    void OnCollisionStay(UnityEngine.Collision collision)
    {
        if (collision.gameObject.name == "Cube") {
            UnityEngine.Debug.Log("LONGER");
            GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
