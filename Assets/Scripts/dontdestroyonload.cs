using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dontdestroyonload : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameObject_;
    void Awake()
    {
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("Music");
        if (musicObj.Length > 1)
        {
            Destroy(this.gameObject);
                    }
        DontDestroyOnLoad(this.gameObject);
        
    }
}