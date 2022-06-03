using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyHavuc : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameObject_;
    void Awake()
    {
        GameObject[] playerObj = GameObject.FindGameObjectsWithTag("Player");
        if (playerObj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }
}