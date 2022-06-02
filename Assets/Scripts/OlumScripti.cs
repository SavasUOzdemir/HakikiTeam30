using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OlumScripti : MonoBehaviour
{
    public GameObject olumMenusu;
       public void Olum()
    {
        olumMenusu.SetActive(true);
    }
    public void AnaMenuTusu()
    {
        
        olumMenusu.SetActive(false);
        SceneManager.LoadScene(0);
    }
}
