using TMPro;
using LootLocker.Requests;
using UnityEngine.UI;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class LeaderboardController : MonoBehaviour
{
    //    public TMP_InputField MemberID; 
    //    public TMP_Text PlayerScore;
    public int LeaderboardID = 3482;
    public TextMeshProUGUI playerNames;
    public TextMeshProUGUI playerScores;
    private void Start()
    {
        
    }

    public IEnumerator SubmitScoreRoutine(int scoreToUpload)
    {
        bool done = false;
        string PlayerID = PlayerPrefs.GetString("PlayerID");
        LootLockerSDKManager.SubmitScore(PlayerID, scoreToUpload, LeaderboardID, (response) =>
           {
               if (response.success)
               {
                   Debug.Log("Skor Yüklendi");
                   done = true;
               }
               else
               {
                   Debug.Log("Baþarýsýz Olundu " + response.Error);
               }
           });
        yield return new WaitWhile(() => done == false);
    }
    public IEnumerator FetchTopHighScoresRoutine()
    {
        bool done = false;
        LootLockerSDKManager.GetScoreListMain(LeaderboardID, 10, 0, (response) =>
           {
               if (response.success)
               {
                   string tempPlayerNames = "Kullanici\n";
                   string tempPlayerScores = "Skor\n";

                   LootLockerLeaderboardMember[] members = response.items;
                   for (int i = 0; i < members.Length; i++)
                   {
                       tempPlayerNames += members[i].rank + ". ";
                       if (members[i].player.name != "")
                       {
                           tempPlayerNames += members[i].player.name;

                       }
                       else
                       {
                           tempPlayerNames += members[i].player.id;
                       }
                       tempPlayerScores += members[i].score + "\n";
                   }
                   done = true;
                   playerNames.text = tempPlayerNames;
                   playerScores.text = tempPlayerScores;
               }
               else
               {
                   Debug.Log("Failed: " + response.Error);
                   done = true;
               }
           });
        yield return new WaitWhile(() => done == false);
    }
}