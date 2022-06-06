using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class PausePlay : MonoBehaviour
{
    public bool is_paused = false;
    public GameObject Pausepanel;


    public void ButtonPause()
    {
        if (is_paused == true)
        {
            is_paused = false;
            Pausepanel.SetActive(false);

            Time.timeScale = 1;
        }
        else
        {
            is_paused = true;
            Pausepanel.SetActive(true);
            Time.timeScale = 0;
        }

    }

    public void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ButtonPause();
            
        }
    }
    //void escapetusu()
    //{
    //        if (is_paused == true)
    //        {
    //            //Time.timeScale = speed_of_game;
    //            Pausepanel.SetActive(false);
    //            speed_of_game = old_speed_of_game;
    //            Time.timeScale = 1;
    //            is_paused = false;
    //        }
    //        else
    //        {            
    //                Pausepanel.SetActive(true);
    //                old_speed_of_game = speed_of_game;
    //                speed_of_game = 0;
    //                //Time.timeScale = 0;
    //                is_paused = true;
    //        Time.timeScale = 0;

    //    }

    //}
}
