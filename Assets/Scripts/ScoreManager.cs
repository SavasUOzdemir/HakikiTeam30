using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public GameObject havuc_;
    public Movement movement_;

    void Awake()
    {
        movement_ = havuc_.GetComponent<Movement>();
    }
     // Update is called once per frame
    void Update()
    {
        scoreText.text = "SKOR: " + movement_.score.ToString();
    }
    
}
