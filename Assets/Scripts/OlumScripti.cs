using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OlumScripti : MonoBehaviour
{
    public GameObject player_;
    public GameObject spawner;
    public GameObject olumMenusu;

       public void Olum()
    {
        olumMenusu.SetActive(true);
    }
    public void AnaMenuTusu()
    {
        
        olumMenusu.SetActive(false);
        Object.Destroy(player_, 0);
        Object.Destroy(spawner, 0);

        SceneManager.LoadScene(0);
    }
}
