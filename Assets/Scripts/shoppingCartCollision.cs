using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class shoppingCartCollision : MonoBehaviour
{
    SpriteRenderer renderReference;
    private deteriorate deter;
    private System.Random rand;

    void Start()
    {
        deter = GameObject.Find("/Scripts").GetComponent<deteriorate>();
        rand = new System.Random();
    }

    //If your GameObject keeps colliding with another GameObject with a Collider, do something
    void OnCollisionEnter(UnityEngine.Collision collision)
    {

        if (collision.gameObject.name == "Meat") {
            UnityEngine.Debug.Log("YAY");
            GetComponent<Renderer>().material.color = Color.yellow;
            foreach(GameObject obj in GameObject.FindObjectsOfType<GameObject>()) {
                if (obj.name == "Tree") {
                    foreach(Transform child in obj.GetComponentsInChildren<Transform>()) {
                        deter.StartCoroutine(deter.Deter(
                            child.gameObject,
                            child.gameObject.name == "Trunk" ? 0.25f : (float)rand.NextDouble(),
                            (float)rand.NextDouble() * 2f + 2f,
                            child.gameObject.name == "Trunk" ? 0 : 1,
                            1f - (float)rand.NextDouble() * .5f
                        ));
                    };
                }
            }
        }
    }
}
