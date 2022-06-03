using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Can : MonoBehaviour
{

    public int health = 3;
    public GameObject UI;
    public GameObject canbir;
    public GameObject caniki;
    public GameObject canuc;
    //private void Awake()
    //{
    //    GetComponent<Collider2D>();
    //}

    //void OnTriggerEnter2D(Collider2D obje)
    //{
    //    if (obje.CompareTag("Dusman"))
    //    {
    //        {
    //            health--;
    //            this.transform.position = new Vector2(-4.43f, -1.15f);
    //            if (health == 2)
    //            {
    //                canuc.SetActive(false);

    //            }
    //            else if (health == 1)
    //            {
    //                caniki.SetActive(false);
    //            }


    //        }
    //    }
    //}
    private void Update()
    {
        if (health == 3)
        {
            canbir.SetActive(true);
            caniki.SetActive(true);
            canuc.SetActive(true);
        }
        if (transform.position.y < -2.5f)
        {
            health--;
            this.transform.position = new Vector2(-4.43f, -1.15f);
            if (health == 2)
            {
                canuc.SetActive(false);
                
            }
            else if (health == 1)
            {
                caniki.SetActive(false);
            }


        }
        if (health == 0)
        {
            canbir.SetActive(false);
            print("Rip havuç");
            Time.timeScale = 0;
            UI.GetComponent<OlumScripti>().Olum();
        }
        }



}
