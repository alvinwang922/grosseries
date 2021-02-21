using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deteriorate : MonoBehaviour
{
    public IEnumerator Deter(
        GameObject obj,
        float goDownThisMuch,
        float speed,
        int level,
        float colOffset
    ) {
        Vector3 initPos = obj.transform.position;
        Vector3 goPos = initPos + new Vector3(0.0f, -goDownThisMuch, 0.0f);
        obj.tag = "Level" + level;

        Renderer rend = obj.GetComponent<Renderer>();

        Color[] cols = new Color[4] {
            rend.material.color,
            new Color(152.0f/255,169.0f/255,128.0f/255, 1),
            new Color(75.0f/255, 82.0f/255, 40.0f/255, 1),
            new Color(75.0f/255, 82.0f/255, 40.0f/255, 0)
        };
        Color col = cols[level] * (level > 0 ? colOffset : 1.0f);

        if (level == 3) {
            rend.material.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
            rend.material.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
            rend.material.SetInt("_ZWrite", 0);
            rend.material.DisableKeyword("_ALPHATEST_ON");
            rend.material.EnableKeyword("_ALPHABLEND_ON");
            rend.material.DisableKeyword("_ALPHAPREMULTIPLY_ON");
            rend.material.renderQueue = 3000;
        }

        while (Vector3.Distance(obj.transform.position, goPos) > 0.01f) {
            obj.transform.position = Vector3.Lerp(obj.transform.position, goPos, Time.deltaTime * speed);
            rend.material.color = Color.Lerp(rend.material.color, col, Time.deltaTime * speed);
            yield return new WaitForEndOfFrame();
        }
    }
    /*
    // Start is called before the first frame update
    public float goDownThisMuch;
    public float speed;
    public int level;

    private Vector3 initPos;
    private Renderer rend;
    private Color col;

    void Start()
    {
        initPos = transform.position;
        gameObject.tag = "Level" + level;

        rend = GetComponent<Renderer> ();

        Color[] cols = new Color[4] {
            rend.material.color,
            new Color(127.0f/255,144.0f/255,70.0f/255, 1),
            new Color(75.0f/255, 82.0f/255, 40.0f/255, 1),
            new Color(75.0f/255, 82.0f/255, 40.0f/255, 0)
        };
        col = cols[level];

        if (level == 3) {
            rend.material.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
            rend.material.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
            rend.material.SetInt("_ZWrite", 0);
            rend.material.DisableKeyword("_ALPHATEST_ON");
            rend.material.EnableKeyword("_ALPHABLEND_ON");
            rend.material.DisableKeyword("_ALPHAPREMULTIPLY_ON");
            rend.material.renderQueue = 3000;
        }
    }

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, initPos + new Vector3(0.0f, -goDownThisMuch, 0.0f), Time.deltaTime * speed);
        rend.material.color = Color.Lerp(rend.material.color, col, Time.deltaTime * speed);
    }
    */
}
