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
    public TextMeshProUGUI text5;
    float iq = 0;
    int memory, calculation, visual, logic;


    // Start is called before the first frame update
    void Start()
    {
        int oyun1skor = PlayerPrefs.GetInt("oyunskor1");
        int oyun2skor = PlayerPrefs.GetInt("oyunskor2");
        int oyun3skor = PlayerPrefs.GetInt("oyunskor3");
        int oyun4skor = PlayerPrefs.GetInt("oyunskor4");
        int oyun5skor = PlayerPrefs.GetInt("oyunskor5");

        memory = oyun1skor * 7 / 10 + oyun5skor * 4 / 10;
        calculation = oyun2skor * 1 / 2 + oyun3skor * 6 / 10;
        visual = oyun1skor * 1 / 10 + oyun3skor * 2 / 10 + oyun4skor * 1 / 10 + oyun5skor * 1 / 2;
        logic = oyun2skor * 1 / 2 + oyun4skor * 1 / 2;


        text1.text = "Memory:    "+memory;
        text2.text = "Calculation:    "+calculation;
        text3.text = "Visual:    "+visual;
        text5.text = "Logic:    " + logic;
        iq = (oyun1skor + oyun2skor + oyun3skor+oyun4skor+oyun5skor)/206;
        text4.text = "IQ\n" + iq;

    }

   public void menu()
    {
        SceneManager.LoadScene(0);
    }

}
