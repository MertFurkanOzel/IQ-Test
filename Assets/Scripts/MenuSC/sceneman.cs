using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class sceneman : MonoBehaviour
{
    bool sesdurumu = true;
    public AudioSource aus;
    
    public void oyun1gec()
    {
        aus.Play();
        SceneManager.LoadScene(1);
    }
    public void oyundancik()
    {
        aus.Play();
        Application.Quit();
    }
    public void sesbuton()
    {
        sesdurumu = !sesdurumu;
        if (sesdurumu)
        {
            AudioListener.volume = 1;
            GameObject.Find("Soundbttn").GetComponent<Image>().color = new Color(255, 255, 255);
        }
            
        else
        {
            GameObject.Find("Soundbttn").GetComponent<Image>().color = new Color(255, 0, 0);
            AudioListener.volume = 0;
        }
            

    }
}
