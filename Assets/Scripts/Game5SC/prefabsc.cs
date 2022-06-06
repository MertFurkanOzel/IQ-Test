using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefabsc : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        Invoke("hareket3", 2f);
    }

    void hareket()
    {
        gameObject.transform.GetComponent<SpriteRenderer>().enabled = false;
        Invoke("hareket2", 2.47f);
    }
    void hareket2()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
        gameObject.transform.GetComponent<SpriteRenderer>().enabled = true;
    }
    void hareket3()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, -1.3f, 0);
        Invoke("hareket", 1f);
    }
}
