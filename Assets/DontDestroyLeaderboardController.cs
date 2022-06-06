using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyLeaderboardController : MonoBehaviour
{
    public GameObject gameObject_;
    void Awake()
    {
        GameObject[] leaderboardContObj = GameObject.FindGameObjectsWithTag("LeaderboardController");
        if (leaderboardContObj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
