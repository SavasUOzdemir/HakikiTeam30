using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gem : MonoBehaviour {
    
    public static int toplanan_gem = 0; 

        private void Awake() {
            GetComponent<Collider2D>().isTrigger = true;
        }
        
        

        void OnTriggerEnter2D(Collider2D obje)
        {
            if (obje.CompareTag("Player"))
            {
                toplanan_gem++;
                Debug.Log("toplam gem: " + toplanan_gem + " tl.");
                Destroy(gameObject);
            }
        }
}
