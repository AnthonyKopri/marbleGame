using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using GoogleMobileAds.Api;

public class AdMobScript : MonoBehaviour
{

    private RewardBasedVideoAd rewardBasedVideoAd;

    #if UNITY_ANDROID
        string APP_ID = "ca-app-pub-3940256099942544/5224354917";
    #elif UNITY_IPHONE
        string APP_ID = "ca-app-pub-3940256099942544/5224354917";
    #else
        string APP_ID = "unexpected_platform";
    #endif


    void Start()
    {
        Debug.Log(APP_ID);
        rewardBasedVideoAd = RewardBasedVideoAd.Instance;
        MobileAds.Initialize(APP_ID);
    }

    
    void Update()
    {
        
    }
}
