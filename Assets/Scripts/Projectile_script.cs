using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Projectile_script : MonoBehaviour
{
    public float hiz = 15f;
    public Rigidbody2D rb;
    public SpriteRenderer sr;
        // Start is called before the first frame update
    void Start()
    {
        if (sr.flipX == false) 
        { 
            rb.velocity = transform.right * hiz; 
        }
        else {  rb.velocity = -transform.right * hiz; } 
    }



    private void Awake()
    {
        GetComponent<Collider2D>().isTrigger = true;
    }



    void OnTriggerEnter2D(Collider2D obje)
    {
        if (obje.CompareTag("Dusman") || obje.gameObject.layer==6)
        {
            Destroy(gameObject);
        }
    }
}
