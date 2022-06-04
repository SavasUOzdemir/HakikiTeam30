using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyFireball : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameObject_;
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
}