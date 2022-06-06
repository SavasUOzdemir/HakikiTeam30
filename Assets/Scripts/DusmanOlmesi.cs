using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DusmanOlmesi : MonoBehaviour
{

    public GameObject havuc_;
    public Movement movement_;
    private void Awake()
    {
        GetComponent<Collider2D>().isTrigger = true;
        movement_ = havuc_.GetComponent<Movement>();
    }



    void OnTriggerEnter2D(Collider2D obje)
    {
        if (obje.CompareTag("HavucSilah"))
        {
            movement_.score += 20;
            Destroy(this.gameObject);
        }
    }
}
