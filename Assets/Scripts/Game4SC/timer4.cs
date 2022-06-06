using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class timer4 : MonoBehaviour
{
    public Image img1, img2;
    public Text zaman;
    public float sure;
    void Start()
    {
        sure = 60f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(sure>0)
        {
            zaman.text = ((int)sure).ToString();
            sure -= Time.deltaTime;
        }

        else
        {
            PlayerPrefs.SetInt("oyunskor4", GetComponent<Main>().puan);
            PlayerPrefs.Save();
            SceneManager.LoadScene(1);
        }
        
        

        img2.fillAmount = sure / 60;
    }
}
