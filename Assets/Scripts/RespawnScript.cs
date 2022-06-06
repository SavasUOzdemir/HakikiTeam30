using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnScript : MonoBehaviour
{
    public GameObject Havuc_;
    public Transform HavucTransform;

    private void Awake()
    {
        HavucTransform = Havuc_.GetComponent<Transform>();
        HavucTransform.position = transform.position;
            }
    void Start()
    {
            if (SceneManager.GetActiveScene().buildIndex == 1)
            {
                transform.position = new Vector2(6.27f, -1.92f);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                transform.position = new Vector2(-10.96f, -1.85f);

            }
            else if (SceneManager.GetActiveScene().buildIndex == 3)
            {
                transform.position = new Vector2(-2.75f, -2.15f);
            }
            else if (SceneManager.GetActiveScene().buildIndex == 4)
            {
                transform.position = new Vector2(-15.91f, -1.93f);


            }
            else if (SceneManager.GetActiveScene().buildIndex == 5)
            {
                transform.position = new Vector2(6.27f, -1.92f);


            }
            else if (SceneManager.GetActiveScene().buildIndex == 6)
            {
                transform.position = new Vector2(-10.49f, -0.81f);


            }
            else if (SceneManager.GetActiveScene().buildIndex == 7)
            {
                transform.position = new Vector2(-4.05f, -2.33f);

            }
            else { return; };

            HavucTransform.position = transform.position;

        
    }
    

}
