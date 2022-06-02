using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onEnable : MonoBehaviour
{
    public GameObject deathmenu;
    // Start is called before the first frame update
    void OnEnable()
    {
        if (deathmenu.activeSelf == true)
        {
            Debug.Log("deathmenu active");
            deathmenu.SetActive(false);
        }
        else
            Debug.Log("deathmenu inactive");
    }
}
