using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    Rigidbody2D rb;
    Animator anim;
    float speed = 5f;
    public float ziplamaGucu = 9.5f;
    bool yerdeMi = false;
    bool ikiZiplama = false;
    public Transform zeminKontrolNoktasi;
    public LayerMask zeminLayer;

    private void Awake() 
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        hareket();
        ziplama();
        yonDegistir();
    }

    private void hareket()
    {
        float h = Input.GetAxis("Horizontal");
        float hiz = h * speed;
        rb.velocity = new Vector2(hiz, rb.velocity.y);
        anim.SetFloat("yuruyor",Mathf.Abs(rb.velocity.x));
    }

    private void ziplama()
    {
        
        yerdeMi = Physics2D.OverlapCircle(zeminKontrolNoktasi.position,0.2f,zeminLayer);
        
        if (Input.GetButtonDown("Jump"))
        {
            if (yerdeMi == true)
            {
                ikiZiplama = true;
                rb.velocity = new Vector2(rb.velocity.x, ziplamaGucu);
            }
            else
            {
                if (ikiZiplama == true)
                {
                    rb.velocity = new Vector2(rb.velocity.x, ziplamaGucu);
                    ikiZiplama = false;
                }
            }
        }
    }

    void yonDegistir() 
    {
        Vector2 geciciScale = transform.localScale;
        if (rb.velocity.x>0)
        {
            geciciScale.x = 0.7f;
        }
        else if(rb.velocity.x<0)
        {
            geciciScale.x = -0.7f;
        }
        transform.localScale = geciciScale;
    }
}
