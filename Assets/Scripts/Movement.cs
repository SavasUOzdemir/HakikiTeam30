using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Movement : MonoBehaviour
{
    public int baslangicpara = 0;
    public int baslangicgem = 0;
    public TMP_Text paraMetni;
    public TMP_Text gemMetni;
    public TMP_Text projektaylMetni;
    public int score = 0;


    SpriteRenderer spriteRenderer_;
    Rigidbody2D rb;
    Animator anim;
    readonly float speed = 5f;
    public float ziplamaGucu = 9.5f;
    bool yerdeMi = false;
    bool ikiZiplama = false;
    public Transform zeminKontrolNoktasi;
    public LayerMask zeminLayer;
    public Ates ates_;
    public Can can_;
    
    
    private void Awake() 
    {

        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        spriteRenderer_ = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        paraMetni.text = baslangicpara.ToString();
        gemMetni.text = baslangicgem.ToString();
        projektaylMetni.text = ates_.projectilesayisi.ToString();
    }

    void Update()
    {
        hareket();
        ziplama();
        yonDegistir();
        projektaylMetni.text = ates_.projectilesayisi.ToString();

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
            AudioManagerScript.PlaySound("jump");

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
            spriteRenderer_.flipX = false;
        }
        else if(rb.velocity.x<0)
        {
            spriteRenderer_.flipX=true;
        }
        transform.localScale = geciciScale;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            AudioManagerScript.PlaySound("coin");
            baslangicpara++;
            paraMetni.text = baslangicpara.ToString();
            score += 10;

        }
        else if (collision.CompareTag("Gem"))
        {
            baslangicgem++;
            gemMetni.text = baslangicgem.ToString();
            score += 50;
        }
        else if (collision.CompareTag("Meyve"))
        {
            AudioManagerScript.PlaySound("MeyveToplama");
            ates_.projectilesayisi = 3;
            if(can_.health != 3)
            can_.health++;
            projektaylMetni.text = ates_.projectilesayisi.ToString();
            score += 5;
        }
    }

}
