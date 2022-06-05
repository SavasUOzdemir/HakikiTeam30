using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ates : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject projectilePrefab;
    public SpriteRenderer havuc;
    public Transform havuctransform;
    bool flipx;
    public GameObject[] playerObject;
    public int projectilesayisi = 3;
    public Movement movement_;
    // Update is called once per frame

        void Update()
    {
        playerObject = GameObject.FindGameObjectsWithTag("Player");
        Positioning();
        
        

        if (Input.GetButtonDown("Fire1")&& projectilesayisi > 0)
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
