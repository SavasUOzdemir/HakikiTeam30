using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kafa_tespit_kod : MonoBehaviour
{
    GameObject dusman;
    void Start()
    {
        dusman = gameObject.transform.parent.gameObject;//kafa tespit gameobjecti parent in altında olusturulacak ve kafaya scale edilecek
    }

    private void OnCollisionEnter2D(Collision2D other) {//o bolgeye temas durumu

        Debug.Log("x");
        GetComponent<Collider2D>().enabled=false;
        dusman.GetComponent<SpriteRenderer>().flipY=true;//dusmanın ters donmesi 
        dusman.GetComponent<Collider2D>().enabled=false;//yerde seken bir dsuman yerine colliderini iptal ediyorum .
        Vector3 movement = new Vector3(Random.Range(40,70),Random.Range(-40,40),0.0f);//rasgele bi yere hareket edcek carptıkan sonra 
        dusman.transform.position +=  movement*Time.deltaTime ;//hareketinin gucu

    }

    void Update()
    {
        
    }
}
