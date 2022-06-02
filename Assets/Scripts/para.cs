using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class para : MonoBehaviour {
    
    public static int toplanan_para = 0; 

        private void Awake() {
            GetComponent<Collider2D>().isTrigger = true;
        }
        
        

        void OnTriggerEnter2D(Collider2D obje)
        {
            if (obje.CompareTag("Player"))
            {
                toplanan_para++;
                Debug.Log("toplam para: " + toplanan_para + " tl.");
                Destroy(gameObject);
            }
        }
}
