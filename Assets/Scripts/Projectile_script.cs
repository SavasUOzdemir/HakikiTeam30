using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Projectile_script : MonoBehaviour
{
    public float hiz = 15f;
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    float x = 0f;
    float absdistance;
    // Start is called before the first frame update
    void Start()
    {
        x = transform.position.x;
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


    private void Update()
    {
        absdistance = Mathf.Abs(transform.position.x - x);
        if (absdistance>=15)
        {
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D obje)
    {
        if (obje.CompareTag("Dusman") || obje.gameObject.layer==6)
        {
            Destroy(gameObject);
        }
    }
}
