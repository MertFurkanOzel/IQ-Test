using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Denemex : MonoBehaviour
{
    int[] sayilar ={ 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    List<int> values;
    public TextMeshProUGUI scoretext;
    public Canvas kanvas;
    public GameObject circle;
    int adet = 6;
    float deger;
    int kacinci = 1;
    public int score=0;
    public AudioSource lvlgecis;
    public AudioSource dogru;
    public AudioSource yanlıs;
    public void Start()
    {
       
        values = new List<int>();
        gencircle(adet);
        
       
    }
    public void gencircle(int adet)
    {
        lvlgecis.Play();
        kacinci = 1;
        values.Clear();
        GameObject[] circles = new GameObject[adet];
        for(int i=0;i<adet;i++)
        {
            
            circles[i]=Instantiate(circle,circle.transform.position,Quaternion.identity);
            circles[i].transform.SetParent(kanvas.transform);
            circles[i].transform.position = new Vector3(circle.transform.position.x + 300 * (i + 1), circle.transform.position.y, circle.transform.position.z);
            circles[i].SetActive(true);
            randomtext(circles[i]);

        }
        
    }
  
    void randomtext(GameObject a)
    {
        float val;
        int randomsayi1 =Random.Range(1, 80);
        int randomsayi2 = Random.Range(1, 80);
        int randomsayi3 = Random.Range(1, 6);
        int randomsayi4 = Random.Range(1, 9);


        switch (randomsayi3)
        {

            case 1:
                randomsayi1 %= 9;
                randomsayi2 %= 9;
                val= randomsayi1 + randomsayi2;
                a.GetComponent<CircleValue>().Value = val;
                a.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = randomsayi1+ "+" + randomsayi2;
                values.Add((int)val);
                
                break;
            case 2:
                if(randomsayi1>randomsayi2)
                {
                    int temp = randomsayi2;
                    randomsayi2 = randomsayi1;
                    randomsayi1 = temp;
                }
                val= randomsayi2 - randomsayi1;
                a.GetComponent<CircleValue>().Value = val;
                a.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = randomsayi2 + "-" + randomsayi1;
                values.Add((int)val);
                
                break;
            case 3:
                randomsayi1 %= 9;
                randomsayi2 %= 9;
                randomsayi1++;
                randomsayi2++;
                val= randomsayi1 * randomsayi2;
                a.GetComponent<CircleValue>().Value = val;
                a.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = randomsayi1 + "*" + randomsayi2;
                values.Add((int)val);
               
                break;
            case 4:
                val= randomsayi1 / randomsayi4;
                a.GetComponent<CircleValue>().Value = val;
                a.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = randomsayi1 + "/" + randomsayi4;
                values.Add((int)val);
               
                break;
            default:
                randomsayi1 = (randomsayi1 % 5) + 1;
                a.GetComponent<CircleValue>().Value = randomsayi1;
                a.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = randomsayi1.ToString();
                values.Add(randomsayi1);
               
                break;
        }
        values.Sort();





    }

    public bool dogrumu(float deger)
    {
        if (values[kacinci-1] == deger)
        {
            dogru.Play();
            kacinci++;
            score += 150;
            scoretext.text = "Score: " + score.ToString();
            return true;
        }
            
        else
        {
            yanlıs.Play();
            score -= 50;
            scoretext.text = "Score: " + score.ToString();
            return false;
        }
            
    }

    
}
