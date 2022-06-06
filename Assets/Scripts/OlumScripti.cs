using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OlumScripti : MonoBehaviour
{
    public GameObject player_;
    public GameObject spawner;
    public GameObject olumMenusu;
    bool cansubmitted = false;
    public LeaderboardController leaderboard;
    public Movement movement_;

    private void Awake()
    {
        movement_= player_.GetComponent<Movement>();
    }

    public void Olum()
    {
        olumMenusu.SetActive(true);
        Invoke("SubmitRoutine", 1f);
        
    }
    public void AnaMenuTusu()
    {
        
        olumMenusu.SetActive(false);
        Object.Destroy(player_, 0);
        Object.Destroy(spawner, 0);

        SceneManager.LoadScene(0);
    }
    public IEnumerator submitScore()
    {
        yield return leaderboard.SubmitScoreRoutine(movement_.score);
    }
    public void SubmitRoutine()
    {
        if (cansubmitted == false)
        {
            StartCoroutine(submitScore());
            cansubmitted = true;
        }
        else
        {
            return;
        };
    }
}
