using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AyakSilah : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform transform_;
    public GameObject gameObject_;

    // Update is called once per frame
 
    void Update()
    {
        Positioning();
    }  
        

        void Positioning()
    {
        {
            this.transform.position = new Vector2(transform_.position.x,transform_.position.y-0.7f);
        }
        
    }
}
