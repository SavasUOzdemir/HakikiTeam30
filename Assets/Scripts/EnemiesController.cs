using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesController : MonoBehaviour
{
    public float hareketHizi = 5f;
    public Transform solHedef, sagHedef;
    bool sagTarafta;
    Rigidbody2D rb;
    public SpriteRenderer sr;

    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Start() {
        solHedef.parent = null;
        sagHedef.parent = null;
        sagTarafta = true;
    }

    private void Update() {
        
        if(sagTarafta)
        {
            sr.flipX = true;
            
            rb.velocity = new Vector2 (hareketHizi, rb.velocity.y);
            
            if (transform.position.x > sagHedef.position.x)
            {
                sagTarafta = false;
            }
            
        }
        else
            {
                sr.flipX = false;
                rb.velocity = new Vector2(-hareketHizi, rb.velocity.y);
                
                if (transform.position.x < solHedef.position.x)
                {
                    sagTarafta = true;
                }
            }
    }
}
