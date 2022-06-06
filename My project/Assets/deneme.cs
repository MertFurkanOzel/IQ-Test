using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class deneme : MonoBehaviour
{
    public Text asd;
    int say = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        say++;
        asd.text = say.ToString();
    }
}
