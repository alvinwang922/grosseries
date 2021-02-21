using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSkybox : MonoBehaviour
{
    // Start is called before the first frame update
    public Material transitionMaterial;
    private Material initSkybox;

    void Start()
    {
        initSkybox = new Material(RenderSettings.skybox);
    }

    // Update is called once per frame
    void Update()
    {
        // RenderSettings.skybox.Lerp(initSkybox, transitionMaterial, Time.deltaTime);
    }
}
