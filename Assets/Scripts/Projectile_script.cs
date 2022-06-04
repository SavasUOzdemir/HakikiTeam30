using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

}
