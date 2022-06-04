using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ates : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject projectilePrefab;
    public Transform transform_;
    public SpriteRenderer havuc;
    public Transform havuctransform;
    bool flipx;
    public GameObject[] playerObject;
    // Update is called once per frame
    
    void Update()
    {
        playerObject = GameObject.FindGameObjectsWithTag("Player");
        Positioning();
        
        

        if (Input.GetButtonDown("Fire1"))
        {
            AtesEt();
            
        }
    }
    void AtesEt()
    {
        Instantiate(projectilePrefab, transform_.position, transform_.rotation);
    }
    void Positioning()
    {
        if (playerObject.Length != 0)
        {
            transform_.position = havuctransform.position;
            flipx = havuc.flipX;
            if (flipx)
            {
                transform_.rotation = Quaternion.Euler(0f, 180f, 0f);
            }
            else
            {
                transform_.rotation = Quaternion.Euler(0f, 0f, 0f);

            }
        }
        else { Destroy(this.gameObject); }
    }
}
