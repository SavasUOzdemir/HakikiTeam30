using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donotdestroy_PM : MonoBehaviour
{
    public GameObject gameObject_;
    void Awake()
    {
        GameObject[] PMObj = GameObject.FindGameObjectsWithTag("PlayerManager");
        if (PMObj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
