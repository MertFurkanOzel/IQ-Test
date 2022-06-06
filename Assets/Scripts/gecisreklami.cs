using GoogleMobileAds.Api;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gecisreklami : MonoBehaviour
{
    private InterstitialAd InterGecisReklami;
    private InterstitialAd InterGecisVideoReklami;
    public string AndroidBannerReklamKimligi;
    public string İosBannerReklamKimligi;
    public string VideoAndroidBannerReklamKimligi;
    public string VideoİosBannerReklamKimligi;
    string Reklamid;
    string Reklamid2;
    public Text logkaydim;

    void Start()
    {
      RequestGecis();
      
    }


    void RequestGecis()
    {
        #if UNITY_ANDROID
                Reklamid = AndroidBannerReklamKimligi;
#elif UNITY_IPHONE
                        Reklamid=İosBannerReklamKimligi;
#else
                        Reklamid = "Tanımsız Platform";
#endif

        InterGecisReklami = new InterstitialAd(Reklamid);

        //InterGecisReklami.OnAdLoaded += yuklendimi;
        //InterGecisReklami.OnAdFailedToLoad += yuklemedesorunvar;
        //InterGecisReklami.OnAdOpening += acildi;
        InterGecisReklami.OnAdClosed += kapatildi;


        AdRequest request = new AdRequest.Builder().Build();
        InterGecisReklami.LoadAd(request);


    }

    


    public void Goster()
    {

        if (InterGecisReklami.IsLoaded())
        {
            InterGecisReklami.Show();

        }
        else
        {
            RequestGecis();
        }
    }
    

    public void yuklendimi(object sender, EventArgs args)
    {

        logkaydim.text = "Reklam yüklendi\n";

    }
    public void yuklemedesorunvar(object sender, AdFailedToLoadEventArgs args)
    {
        logkaydim.text += "Reklam yüklenemedi\n";
        RequestGecis();

    }
    public void acildi(object sender, EventArgs args)
    {
        logkaydim.text += "Reklam Açıldı\n";

    }
    public void kapatildi(object sender, EventArgs args)
    {
        SceneManager.LoadScene(0);
    }
    public void arkaplanaatildimi(object sender, EventArgs args)
    {
        logkaydim.text += "Oyun arkaplanda\n";

    }

    void GecisReklamiKaldir ()
    {

        InterGecisVideoReklami.Destroy();
    }
}
