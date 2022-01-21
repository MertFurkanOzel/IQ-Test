using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class numpadsc : MonoBehaviour
{
    public TextMeshProUGUI tex;
    public TextMeshProUGUI scoretex;
    public int score;
    public AudioSource levelgecs;
    public AudioSource dogru;
    public AudioSource yanlıs;

    int uzunluk;
 

    public void rakambas(int rakam)
    {
        levelgecs.Play();
        if(rakam==0 && tex.text=="")
        {

        }
        else
        {
            if(tex.text.Length<3)
            tex.text += rakam.ToString();
        }
    }
    public void del()
    {
        string qwe = "";
        uzunluk = tex.text.Length;
        for (int i=0;i<uzunluk-1;i++)
        {
            qwe+= tex.text[i];
        }
        tex.text = qwe;
    }
    public void entr()
    {
        if(gameObject.transform.childCount.ToString()==tex.text)
        {
            foreach (Transform child in transform)
            {
                Destroy(child.gameObject);
            }
            dogru.Play();
            score += 250;
            scoretex.text = "Score: " + score;
            tex.text = "";
            GetComponent<KupSC>().generate();
        }
        else 
        {
            yanlıs.Play();
            tex.text = "";
            score -= 100;
            scoretex.text = "Score: " + score;
        }
    }
}
