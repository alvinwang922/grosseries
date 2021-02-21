using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deteriorate : MonoBehaviour
{
    // Start is called before the first frame update
    public float goDownThisMuch;
    public float speed;
    private Vector3 initPos;
    void Start()
    {
        initPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, initPos + new Vector3(0.0f, -goDownThisMuch, 0.0f), Time.deltaTime * speed);
    }
}
