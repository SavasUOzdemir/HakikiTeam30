using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    Transform hedeftransform;
    public GameObject player_;

    private void Update()
    {
        GameObject[] playerObject = GameObject.FindGameObjectsWithTag("Player");
        if (playerObject.Length != 0)
        {
            transform.position = new Vector3(hedeftransform.position.x, transform.position.y, transform.position.z);

            if (transform.position.x < 0)
            {
                transform.position = new Vector3(0, transform.position.y, transform.position.z);
            }
        }
        else { return; }
    }
}
