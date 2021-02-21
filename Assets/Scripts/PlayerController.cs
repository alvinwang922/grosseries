using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private deteriorate deter;
    private System.Random rand;
    // Start is called before the first frame update
    void Start()
    {
        deter = GameObject.Find("/Scripts").GetComponent<deteriorate>();
        rand = new System.Random();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) {
            foreach(GameObject obj in GameObject.FindObjectsOfType<GameObject>()) {
                if (obj.name == "Tree") {
                    foreach(Transform child in obj.GetComponentsInChildren<Transform>()) {
                        deter.StartCoroutine(deter.Deter(
                            child.gameObject,
                            (float)rand.NextDouble(),
                            (float)rand.NextDouble() * 2f + 1f,
                            child.gameObject.name == "Trunk" ? 0 : 1,
                            1f - (float)rand.NextDouble() * .5f
                        ));
                    };
                }
            }
        }
    }

    void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
    }
}
