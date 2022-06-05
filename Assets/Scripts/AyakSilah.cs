using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AyakSilah : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform transform_;
    public GameObject[] playerObject;
    public GameObject gameObject_;

    // Update is called once per frame
    void Awake()
    {
        GameObject[] spawnerObj = GameObject.FindGameObjectsWithTag("ProjectileSource");
        if (spawnerObj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }
    void Update()
    {
        playerObject = GameObject.FindGameObjectsWithTag("Player");
        Positioning();
    }  
        

        void Positioning()
    {
        if (playerObject.Length != 0)
        {
            this.transform.position = transform_.position;
            
        }
        else 
        { 
            Destroy(this.gameObject); 
        }
    }
}
