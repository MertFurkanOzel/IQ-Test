using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gridsign : MonoBehaviour
{
   
    public bool sign = false;


    public void OnMouseDown()
    {
        if(sign&& transform.GetChild(0).GetComponent<SpriteRenderer>().enabled == false)
        {
            transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("GameCont").GetComponent<Controllr>().puanart();

        }
        else if(!sign)
        {
            
            GameObject.Find("GameCont").GetComponent<Controllr>().puanazalt();

        }
    }
}
