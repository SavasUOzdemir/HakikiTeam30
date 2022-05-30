using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    Transform hedeftransform;

    private void Update() {
        transform.position=new Vector3(hedeftransform.position.x,transform.position.y,transform.position.z);   
        
        if (transform.position.x<0)
        {
            transform.position = new Vector3(0,transform.position.y,transform.position.z);
        }
    }
}
