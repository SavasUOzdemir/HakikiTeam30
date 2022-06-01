using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dontdestroyonload : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameObject_;
    void Start()
    {
        DontDestroyOnLoad(gameObject_);
    }
}