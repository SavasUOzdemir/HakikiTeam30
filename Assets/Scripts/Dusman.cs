using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dusman : MonoBehaviour
{

    [SerializeField]
    Transform hedeftransform;
    public GameObject player_;

    private void Awake()
    {
        GetComponent<Collider2D>().isTrigger = true;
    }
    private void Update()
    {
        GameObject[] playerObject = GameObject.FindGameObjectsWithTag("Player");
        if (playerObject.Length != 0)
        {
            transform.position = new Vector3(hedeftransform.position.x, hedeftransform.position.y-2.5F, transform.position.z);
                        
        }
        else { return; }
    }
    void OnTriggerEnter2D(Collider2D obje)
    {
    if (obje.CompareTag("Dusman"))
    {
        Destroy(obje.gameObject);
    }
}
}
