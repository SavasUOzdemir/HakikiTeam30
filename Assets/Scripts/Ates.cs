using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ates : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject projectilePrefab;
    public SpriteRenderer havuc;
    public Transform havuctransform;
    public PausePlay paused_;
    public Canvas canvas;
    bool ispaused = false;
    bool flipx;
    public GameObject[] playerObject;
    public int projectilesayisi = 3;
    public Movement movement_;
    // Update is called once per frame
    private void Awake()
    {
        paused_ = canvas.GetComponent<PausePlay>();
    }
    void Update()
    {
        ispaused = paused_.is_paused;
        playerObject = GameObject.FindGameObjectsWithTag("Player");
        Positioning();
        
        

        if (Input.GetButtonDown("Fire1")&& projectilesayisi > 0&&ispaused==false)
        {
            
            AtesEt();
            
        }
    }
    void AtesEt()
    {
        Instantiate(projectilePrefab, transform.position, transform.rotation);
        projectilesayisi--;
    }
    void Positioning()
    {
        if (playerObject.Length != 0)
        {
            transform.position = havuctransform.position;
            flipx = havuc.flipX;
            if (flipx)
            {
                transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            }
            else
            {
                transform.rotation = Quaternion.Euler(0f, 0f, 0f);

            }
        }
        else 
        { 
            Destroy(this.gameObject); 
        }
    }
}
