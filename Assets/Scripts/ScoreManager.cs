using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;
    int score = 0;
        void Start()
    {
        scoreText.text = "SKOR: "+ " "+score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
