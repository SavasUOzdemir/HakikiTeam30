using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LootLocker.Requests;
<<<<<<< Updated upstream
=======
using TMPro;
>>>>>>> Stashed changes

public class PlayerManager : MonoBehaviour

{    public LeaderboardController leaderboard;
<<<<<<< Updated upstream
=======
    public TMP_InputField playerNameInputField;

>>>>>>> Stashed changes
    IEnumerator SetupRoutine()
    {
        yield return LoginRoutine();
        yield return leaderboard.FetchTopHighScoresRoutine();
    }
<<<<<<< Updated upstream
=======
    public void SetPlayerName()
    {
        LootLockerSDKManager.SetPlayerName(playerNameInputField.text, (response) =>
        {
            if (response.success)
            {
                Debug.Log("Oyuncu Ad� Belirlendi");
            }
            else {
                Debug.Log("Oyuncu Ad� Belirlenemedi" + response.Error); 
                };
        });
    }
>>>>>>> Stashed changes
    IEnumerator LoginRoutine()
    {
        bool done = false;
        LootLockerSDKManager.StartGuestSession((response) =>
        {
            if (response.success)
            {
                Debug.Log("Oyuncu Login Yapt�");
                PlayerPrefs.SetString("PlayerID", response.player_id.ToString());
                done = true;
            }
            else
            {
                Debug.Log("Oturum a��lamad�");
            }
        });
        yield return new WaitWhile(() => done == false);
    }
    private void Start()
    {
        StartCoroutine(SetupRoutine());
    }
}