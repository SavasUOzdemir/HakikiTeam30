using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LootLocker.Requests;

public class PlayerManager : MonoBehaviour

{    public LeaderboardController leaderboard;
    IEnumerator SetupRoutine()
    {
        yield return LoginRoutine();
        yield return leaderboard.FetchTopHighScoresRoutine();
    }
    IEnumerator LoginRoutine()
    {
        bool done = false;
        LootLockerSDKManager.StartGuestSession((response) =>
        {
            if (response.success)
            {
                Debug.Log("Oyuncu Login Yaptý");
                PlayerPrefs.SetString("PlayerID", response.player_id.ToString());
                done = true;
            }
            else
            {
                Debug.Log("Oturum açýlamadý");
            }
        });
        yield return new WaitWhile(() => done == false);
    }
    private void Start()
    {
        StartCoroutine(SetupRoutine());
    }
}