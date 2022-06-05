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
    public SpriteRenderer sr;

    private void Awake()
    {
        GetComponent<Collider2D>();
        sr = GetComponent<SpriteRenderer>();
        
    }


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

    void Update()
    {
        CanManager();
        
    }


    void CanManager()
    {
        if (health == 3)
        {
            canbir.SetActive(true);
            caniki.SetActive(true);
            canuc.SetActive(true);
        }

        else if (health == 2)
        {
            canbir.SetActive(true);
            caniki.SetActive(true);
            canuc.SetActive(false);
        }
        else if (health == 1)
        {
            canbir.SetActive(true);
            caniki.SetActive(false);
            canuc.SetActive(false);
        }
        else if (health == 0)
        {
            canbir.SetActive(false);
            print("Rip havuc");
            Time.timeScale = 0;
            UI.GetComponent<OlumScripti>().Olum();
        }
    }
    void OnTriggerEnter2D(Collider2D obje)
    {
        if (obje.CompareTag("Dusman")|| obje.CompareTag("dusupolmenoktasi"))
        {
            {
                health--;
                StartCoroutine(DeathFlash());
            }
        }
    }
    IEnumerator DeathFlash()
    {
        sr.color = new Color(1f, 1f, 1f, 0f); 
        yield return new WaitForSeconds(0.04f);
        sr.color = new Color(1f, 1f, 1f, 1f);
        yield return new WaitForSeconds(0.04f);
        sr.color = new Color(1f, 1f, 1f, 0f);
        yield return new WaitForSeconds(0.04f);
        sr.color = new Color(1f, 1f, 1f, 1f);
        yield return new WaitForSeconds(0.04f);
        sr.color = new Color(1f, 1f, 1f, 0f);
        yield return new WaitForSeconds(0.04f);
        sr.color = new Color(1f, 1f, 1f, 1f);
        yield return new WaitForSeconds(0.04f);
        sr.color = new Color(1f, 1f, 1f, 0f);
        yield return new WaitForSeconds(0.04f);
        sr.color = new Color(1f, 1f, 1f, 1f);
        yield return new WaitForSeconds(0.04f);
        sr.color = new Color(1f, 1f, 1f, 0f);
        yield return new WaitForSeconds(0.04f);
        sr.color = new Color(1f, 1f, 1f, 1f);
        yield return new WaitForSeconds(0.04f);
        sr.color = new Color(1f, 1f, 1f, 0f);
        yield return new WaitForSeconds(0.04f);
        sr.color = new Color(1f, 1f, 1f, 1f);
        yield return new WaitForSeconds(0.04f);
        sr.color = new Color(1f, 1f, 1f, 0f);
        yield return new WaitForSeconds(0.04f);
        sr.color = new Color(1f, 1f, 1f, 1f);


    }
}