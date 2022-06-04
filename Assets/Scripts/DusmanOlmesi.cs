using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DusmanOlmesi : MonoBehaviour
{


    private void Awake()
    {
        GetComponent<Collider2D>().isTrigger = true;
    }



    void OnTriggerEnter2D(Collider2D obje)
    {
        if (obje.CompareTag("HavucSilah"))
        {
            Destroy(gameObject);
        }
    }
}
