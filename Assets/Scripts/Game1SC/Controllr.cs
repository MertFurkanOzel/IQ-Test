using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Controllr : MonoBehaviour
{
    //public GameObject[] ikonlar;
    public AudioSource aus;
    public int puan = 0;
    int iconsayısı = 0;
    public Text TextPuan;
    public int level = 1;
    int yanlisclicksayisi = 0;
    float puancarpan;
    //float timer = 5f;

    public void Awake()
    {
        transform.GetComponent<Zaman>().enabled = true;
        Invoke("Iconkaybet",3f);
    }

    public void puanart()
    {
        
        puan += 100;
        TextPuan.text = puan.ToString();
        
        if ((puan+(yanlisclicksayisi*50)) / 100 == iconsayısı)
        {
            level++;
            nextlevel();
        }
    }
    public void puanazalt()
    {
        aus.Play();
        yanlisclicksayisi++;
        puan -= 50;
        TextPuan.text = puan.ToString();
        
    }

    public void nextlevel()
    {
        for (int i = 0; i < transform.childCount; i++)
            Destroy(transform.GetChild(i).gameObject);
        transform.DetachChildren();
        transform.GetComponent<GenGrid>().generate();
        transform.GetComponent<Randomicon>().iconolustur();  
        Invoke("Iconkaybet", 3f);
        
        


    }
    void Iconkaybet()
    {
        
            for (int i = 0; i < transform.childCount; i++)
            {
                if (transform.GetChild(i).GetComponent<Gridsign>().sign == true)
                {
                    transform.GetChild(i).GetChild(0).GetComponent<SpriteRenderer>().enabled = false;
                    iconsayısı++;
                }

            }
        
    }

    //void iconolustur()
    //{

    //}


}
//puan 20/60-time
