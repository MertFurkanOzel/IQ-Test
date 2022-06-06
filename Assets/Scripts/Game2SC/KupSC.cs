using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KupSC : MonoBehaviour
{
    int[] katsayisi;
    Vector3 anavector;
    int a;
    public GameObject mavi;
    GameObject objem;
    List<int> asd = new List<int>();
    //public GameObject pembe;
    //public GameObject mor;
    //public GameObject yesil;



    //Vector3 bir = new Vector3(1.29f, 0.75f);
    //Vector3 iki = new Vector3(.86f, 0.5f);
    //Vector3 uc = new Vector3(.43f, 0.25f);
    //Vector3 dort = new Vector3(0, 0);

    //Vector3 bes = new Vector3(1.72f, 0.5f);
    //Vector3 altı = new Vector3(1.29f, 0.25f);
    //Vector3 yedi = new Vector3(.86f, 0);
    //Vector3 sekiz = new Vector3(.43f, -.25f);

    //Vector3 dokuz = new Vector3(2.15f, 0.25f);
    //Vector3 on = new Vector3(1.72f, 0);
    //Vector3 onbir = new Vector3(1.29f, -0.25f);
    //Vector3 oniki = new Vector3(.86f, -0.5f);

    //Vector3 onuc = new Vector3(2.58f, 0);
    //Vector3 ondort = new Vector3(2.15f, -0.25f);
    //Vector3 onbes = new Vector3(1.72f, -.5f);
    //Vector3 onaltı = new Vector3(1.29f, -0.75f);


    public void Start()
    {

        //    int mod;
        //    float x = 0, y = 0;


        //    for (int i=0;i<Random.Range(6,20); i++)
        //    {
        //        a = Random.Range(0, 15);
        //        while (asd.Contains(a))
        //        {
        //            a = Random.Range(0,15);
        //        }

        //        //if (asd.Contains(a))
        //        //    katsayisi[a] += 1;
        //        //else
        //        asd.Add(a);




        //        if (a / 4 == 3)
        //        { x = 2.58f;y = 0; }

        //        if (a / 4 == 2)
        //        { x = 2.15f; y = 0.25f; }

        //        if (a / 4 == 1)
        //        { x = 1.72f; y = 0.5f; }

        //        if (a / 4 == 0)
        //        { x = 1.29f; y = 0.75f; }

        //        mod = a % 4;

        //        //anavector = new Vector3((mod*0.43f)+x,(katsayisi[a]*0.5f)+(y+(mod *0.25f)));
        //        anavector = new Vector3(x-((mod)*0.43f),(katsayisi[a]*0.5f)+y-((mod)*0.25f));
        //        objem =Instantiate(mavi, anavector, Quaternion.identity);
        //        objem.transform.SetParent(this.transform);
        //        objem.GetComponent<SpriteRenderer>().sortingOrder = a;



        //    }
        //    Debug.Log(transform.childCount);

        generate();
    }

    public void generate()
    {
        katsayisi = new int[16];
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
        int randomsayi = Random.Range(5, 15);
        asd.Clear();
        int mod;
        float x = 0, y = 0;


        for (int i = 0; i <randomsayi ; i++)
        {
            
            a = Random.Range(0, 15);
            while (asd.Contains(a))
            {
                a = Random.Range(0, 15);
            }

            //if (asd.Contains(a))
            //    katsayisi[a] += 1;
            //else
               asd.Add(a);




            if (a / 4 == 3)
            { x = 2.58f; y = 0; }

            if (a / 4 == 2)
            { x = 2.15f; y = 0.25f; }

            if (a / 4 == 1)
            { x = 1.72f; y = 0.5f; }

            if (a / 4 == 0)
            { x = 1.29f; y = 0.75f; }

            mod = a % 4;

            //anavector = new Vector3((mod*0.43f)+x,(katsayisi[a]*0.5f)+(y+(mod *0.25f)));
            anavector = new Vector3(x - ((mod) * 0.43f), (katsayisi[a] * 0.5f) + y - ((mod) * 0.25f));
            objem = Instantiate(mavi, anavector, Quaternion.identity);
            objem.transform.SetParent(transform);
            objem.GetComponent<SpriteRenderer>().sortingOrder = a;

        }





    }

}
