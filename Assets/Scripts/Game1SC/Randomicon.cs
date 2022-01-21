using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomicon : MonoBehaviour
{
    float boyut;
    int random1,karesayisi,karesayisiupdate;
    public GameObject[] icons;
    GameObject temp;
    Transform tr;
    int level = 0;

    public void Awake()
    {
        level++;
        iconolustur();
        
    }
    
    public void iconolustur()
    {

        //boyut = GetComponent<GenGrid>().cols;
        //karesayisi = boyut * boyut;
        //Debug.Log(karesayisi);
        karesayisi = transform.childCount;
        boyut =Mathf.Sqrt(karesayisi);
        random1 = Random.Range(0, 3);
        
        
        for (int i = 0; i <boyut  + random1;)
        {

            tr = transform.GetChild(Random.Range(0,karesayisi));
            while (tr.GetComponent<Gridsign>().sign == true)
            {
                tr = transform.GetChild(Random.Range(0,karesayisi));
            }
            //if (tr.GetComponent<click>().sign == false)

            tr.GetComponent<Gridsign>().sign = true;
            temp = Instantiate(icons[i % 5], tr.transform.position, Quaternion.identity);
            temp.transform.SetParent(tr);
            i++;

        }

    }

    /*
     * 3-->4-5
     * 4-->5-6
     * 5-->6-7
     * 6-->7-8
    */


}
