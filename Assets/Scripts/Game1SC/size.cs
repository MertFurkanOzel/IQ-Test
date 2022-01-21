using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class size : MonoBehaviour
{
    GameObject cam;
    float a;

    void Start()
    {
        cam = GameObject.Find("Main Camera");
        
        //gameObject.transform.localScale = new Vector3(.5f, .5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        a = cam.GetComponent<Camera>().orthographicSize / 4;
        gameObject.transform.localScale = new Vector3(a, a, 0);
    }
}
