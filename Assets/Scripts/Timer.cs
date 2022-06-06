using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
   
public float sure;
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

    public void Update()
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
        if (sure_.Seconds <= 9)
        {
            sureMetni.text = sure_.Minutes.ToString() + ":0" + sure_.Seconds.ToString();

        }
        else { 
        sureMetni.text = sure_.Minutes.ToString() + ":" + sure_.Seconds.ToString();
        }
    }
}
