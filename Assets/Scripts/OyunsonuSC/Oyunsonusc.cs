using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Oyunsonusc : MonoBehaviour
{
    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    public TextMeshProUGUI text3;
    public TextMeshProUGUI text4;
    float iq = 0;


    // Start is called before the first frame update
    void Start()
    {
        int oyun1skor = PlayerPrefs.GetInt("oyunskor1");
        int oyun2skor = PlayerPrefs.GetInt("oyunskor2");
        int oyun3skor = PlayerPrefs.GetInt("oyunskor3");

        text1.text = "Oyun1 skorunuz:    "+oyun1skor;
        text2.text = "Oyun2 skorunuz:    "+oyun2skor;
        text3.text = "Oyun3 skorunuz:    "+oyun3skor;
        iq = (oyun1skor + oyun2skor + oyun3skor)/140;
        text4.text = "IQ\n\n" + iq;

    }

   public void menu()
    {
        SceneManager.LoadScene(0);
    }

}
