using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class PausePlay : MonoBehaviour
{
    public static int speed_of_game = 1, old_speed_of_game = 1;
    public bool is_paused = false;
    public float zaman;
    public GameObject Pausepanel;


    public void ButtonPause()
    {
        if (is_paused == true)
        {
            Pausepanel.SetActive(false);
            speed_of_game = old_speed_of_game;
            Time.timeScale = 1;
            is_paused = false;
        }
        else
        {
            Pausepanel.SetActive(true);
            old_speed_of_game = speed_of_game;
            speed_of_game = 0;
            Time.timeScale = 0;
            is_paused = true;
        }

    }

    private void Update()
    {
        zaman += Time.deltaTime * speed_of_game;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (is_paused == true)
            {
                //Time.timeScale = speed_of_game;
                Pausepanel.SetActive(false);
                speed_of_game = old_speed_of_game;
                Time.timeScale = 1;
                is_paused = false;
            }
            else if (Input.GetKeyDown(KeyCode.Escape))
            {
                {
                    Time.timeScale = 0;
                    Pausepanel.SetActive(true);
                    old_speed_of_game = speed_of_game;
                    speed_of_game = 0;
                    //Time.timeScale = 0;
                    is_paused = true;
                }

            }
        }
    }
}
