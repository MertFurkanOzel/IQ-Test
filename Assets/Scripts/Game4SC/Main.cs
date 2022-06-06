using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public AudioSource dogru;
    public AudioSource yanlıs;
    public TextMeshProUGUI tex,tex2;
    public Text text1, text2;
    public int puan = 0,dogrusayisi=0,yanlissayisi=0,x;
    
   string[] dizi = { "SİYAH", "BEYAZ","MAVİ","KIRMIZI","YEŞİL"};
    int cevap;
    // Start is called before the first frame update
    void Start()
    {

        level1();
        
    }

    void olustur()
    { 
        if(Random.Range(0,2)>0)
        {
            text1.text = dizi[cevap];
            text2.text = dizi[x];

        }
        else
        {
            text2.text = dizi[cevap];
            text1.text = dizi[x];
        }

    }

    int level1()
    {
        cevap = Random.Range(0, 2);
        x = cevap;
        switch (cevap)
        {
            case 0:
                tex.color = Color.black;
                break;
            case 1:
                tex.color = Color.white;
                break;
        }
       
        while(x==cevap)
        {
            x = Random.Range(0, 2);
        }
        tex.text = dizi[x];
        olustur();
        return cevap;
    }
    int level2()
    {
        cevap = Random.Range(0, 3);
        x = cevap;
        switch (cevap)
        {
            case 0:
                tex.color = Color.black;
                break;
            case 1:
                tex.color = Color.white;
                break;
            case 2:
                tex.color = Color.blue;
                break;
        }
        while (x == cevap)
        {
            x = Random.Range(0, 3);
        }
        tex.text = dizi[x];
        olustur();
        return cevap;
    }
    int level3()
    {
        cevap = Random.Range(0, 4);
        x = cevap;
        switch (cevap)
        {
            case 0:
                tex.color = Color.black;
                break;
            case 1:
                tex.color = Color.white;
                break;
            case 2:
                tex.color = Color.blue;
                break;
            case 3:
                tex.color = Color.red;
                break;
        }
        while (x == cevap)
        {
            x = Random.Range(0, 4);
        }
        tex.text = dizi[x];
        olustur();
        return cevap;
    }
    int level4()
    {
        cevap = Random.Range(0, 5);
        x = cevap;
        switch (cevap)
        {
            case 0:
                tex.color = Color.black;
                break;
            case 1:
                tex.color = Color.white;
                break;
            case 2:
                tex.color = Color.blue;
                break;
            case 3:
                tex.color = Color.red;
                break;
            default:
                tex.color = Color.green;
                break;
        }
        while (x == cevap)
        {
            x = Random.Range(0, 5);
        }
        tex.text = dizi[x];
        olustur();
        return cevap;
    }

   public void button1()
    {
        if(text1.text==dizi[cevap])
        {
            puan +=100;
            dogrusayisi++;
            dogru.Play();
            levelac(dogrusayisi / 2);
        
        }
        else
        {
            puan -= 75;
            yanlissayisi++;
            yanlıs.Play();
        }
        tex2.text = "Score: " + puan.ToString();
    }

   public void button2()
    {
        if (text2.text == dizi[cevap])
        {
            puan += 120;
            dogrusayisi++;
            dogru.Play();
            levelac(dogrusayisi / 2);
        }
        else
        {
            puan -= 200;
            yanlissayisi++;
            yanlıs.Play();
        }
        tex2.text = "Score:  " + puan.ToString();
    }
    void levelac(int s)
    {
        if (s == 0)
            level1();
        else if (s == 1)
            level2();
        else if (s ==2)
            level3();
        else
            level4();
    }
}   


