using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    Transform hedeftransform;
    public GameObject player_;

    private void LateUpdate()
    {
        GameObject[] playerObject = GameObject.FindGameObjectsWithTag("Player");
        if (playerObject.Length != 0)
        {
            transform.position = new Vector3(hedeftransform.position.x, hedeftransform.position.y, transform.position.z);

            if (transform.position.x < 0)
            {
                transform.position = new Vector3(0, transform.position.y, transform.position.z);
            }

            if (transform.position.y>0)
            {
                transform.position = new Vector3 (transform.position.x, 0, transform.position.z);
            }
        }
        else { return; }
    }
}
