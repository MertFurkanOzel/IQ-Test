using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timr : MonoBehaviour
{
    public Text suretx;
    public Image bar1;
    public Image bar2;
    public float sure;
    void Start()
    {
        sure = 60;
    }

    // Update is called once per frame
    void Update()
    {

        if (sure > 0)
        {
            suretx.text = ((int)sure).ToString();

            sure -= Time.deltaTime;
        }

        else
        {
            
            PlayerPrefs.SetInt("oyunskor3", GetComponent<Denemex>().score);
            PlayerPrefs.Save();
            SceneManager.LoadScene(1);
        }
            
        bar2.fillAmount = sure / 60;

    }
}