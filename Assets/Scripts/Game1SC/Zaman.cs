using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Zaman : MonoBehaviour
{
    public Text suretext;
    public float sure;
    public Image timebar;
    public Image timebar2;

    // Start is called before the first frame update
    void Start()
    {
        sure = 60;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        
        if(sure>0)
        {
            suretext.text = ((int)(sure)).ToString();
            sure -= Time.deltaTime;
            
        }
        else 
        {
            
            PlayerPrefs.SetInt("oyunskor1", GetComponent<Controllr>().puan);
            PlayerPrefs.Save();
            SceneManager.LoadScene(1);
        }
        timebar2.fillAmount = sure / 60;
    }
}
