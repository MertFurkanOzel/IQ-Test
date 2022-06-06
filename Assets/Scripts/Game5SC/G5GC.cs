using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class G5GC : MonoBehaviour
{
    public AudioSource as1, as2;
    public TextMeshProUGUI skortext;
    public GameObject panell;
    Sprite cevap;
    int cevapint;
    public Button[] butonlar=new Button[3];
    public GameObject[] ikonlar = new GameObject[7];
    GameObject[] icons;
    int dogru = 0, yanlis = 0, toplam = 0;
     int level = 3;
    public GameObject portalin, portalout;
    int b;
    public int skor;
    void Start()
    {


        ikonolustur();
        
    }

    // Update is called once per frame
    void Update()
    {
        toplam = dogru - yanlis;
        if (toplam >= 2 && toplam <= 4)
            level = 4;
        else if (toplam > 4)
            level = 5;
        Debug.Log(level);
    }

    void ikonolustur()
    {
        panell.SetActive(false);
        for (int i = 0; i < 3; i++)
        {

            butonlar[i].GetComponent<Image>().sprite = null;

           
        }
        b = Random.Range(0, level);
        float distance = 6.7f;
        int a = Random.Range(0, 7);
        icons= new GameObject[level];
        List<int> liste = new List<int>();
        for (int i=0;i<level;i++)
        {
            while(liste.Contains(a))
            {
                a = Random.Range(0, 7);
            }
            liste.Add(a);
            
            Vector3 vekt = new Vector3(portalin.transform.position.x + distance/(level-1)*i, portalin.transform.position.y, 0);
            icons[i]=Instantiate(ikonlar[a], vekt, Quaternion.identity);
            icons[i].transform.SetParent(transform);
            
        }
        ikonyoket();
        panel(liste);
        
        
    }

    void ikonyoket()
    {
        
        cevap = icons[b].GetComponent<SpriteRenderer>().sprite;
        Destroy(icons[b],3.5f);
        Invoke("ses", 3.1f);
        Invoke("panelac", 5.7f);
        
        
        

    }
    void ses()
    {
        as2.Play();
    }
    void panelac()
    {
        panell.SetActive(true);
    }
   void panel(List<int> liste)
    {
        List<int> iki = new List<int>();
        int c = Random.Range(0, 3);
        for(int i=0;i<2;i++)
        {
            int a = Random.Range(0, 7);
            while (liste.Contains(a))
            {
                a = Random.Range(0, 7);
            }
            liste.Add(a);
            while(iki.Contains(c))
            {
                c = Random.Range(0, 3);
            }
            iki.Add(c);
            butonlar[c].GetComponent<Image>().sprite = ikonlar[a].GetComponent<SpriteRenderer>().sprite;
        }

        for(int i=0;i<3;i++)
        {
            if(butonlar[i].GetComponent<Image>().sprite==null)
            {
                butonlar[i].GetComponent<Image>().sprite = cevap;
                cevapint = i;
            }
        }
        
       
   }
    public void dogrumu(int sayi)
    {
        if(sayi==cevapint)
        {
            as1.Play();
            dogru++;
            skor += level * 150;
            for (int i = 0; i < transform.childCount; i++)
                Destroy(transform.GetChild(i).gameObject);
            transform.DetachChildren();
            ikonolustur();
        }
        else
        {
            yanlis++;
            skor -= 300;

        }
        skortext.text = "Score: " + skor;
    }

}
