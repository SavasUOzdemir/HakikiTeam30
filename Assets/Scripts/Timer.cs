using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
   
    float sure;
    public int baslangicSaniyeSure;
    public TMP_Text sureMetni;
    public bool sureAktif = true;
    //public GameObject pausecheck;
    //public bool ispaused;

    // Start is called before the first frame update
    void Start()
    {
        sure = baslangicSaniyeSure;
    }

    // Update is called once per frame

    void Update()
    {
        //if (sureAktif==true)
        //{
            sure = sure - Time.deltaTime;
            if (sure <= 0f)
            {
                sure=0f;

            }
        //}
        TimeSpan sure_ = TimeSpan.FromSeconds(sure);
        sureMetni.text = sure_.Minutes.ToString() + ":" + sure_.Seconds.ToString();

    }
}
