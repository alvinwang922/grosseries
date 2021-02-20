using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0.0f, 4.0f, -5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate () {
        transform.position = player.transform.position + offset;
    }
}
