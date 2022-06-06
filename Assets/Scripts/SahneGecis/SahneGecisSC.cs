using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class SahneGecisSC : MonoBehaviour
{
    public TextMeshProUGUI text;
    public float time;
    int inttime, kacinci;
    
    private void Start()
    {
       
        kacinci = PlayerPrefs.GetInt("Sonoyun");
        time = 4f;
    }
    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        inttime = ((int)(time));
        text.text = inttime.ToString();
        text.fontSize = inttime * 100;
        Debug.Log(inttime);
        if(inttime<1)
        {
            SahneGecis();
        }
;   }
    void SahneGecis()
    {
        kacinci++;
        PlayerPrefs.SetInt("Sonoyun", kacinci);
        
        SceneManager.LoadScene(kacinci);
        kontrol();
    }
    void kontrol()
    {
        if (PlayerPrefs.GetInt("Sonoyun") == 7)
        {
            PlayerPrefs.SetInt("Sonoyun", 0);
            SceneManager.LoadScene(7);           
        }
       
            
    }
}
