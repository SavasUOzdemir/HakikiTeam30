using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public GameObject basilmisobject;
    public GameObject basilmamisobject;
    private void Awake()
    {
        Time.timeScale = 1;
        basilmisobject.SetActive(false);
        basilmamisobject.SetActive(true);
    }
    public void PlayGame()
    {
        if (basilmisobject.activeSelf == false)
        {
            StartCoroutine(ClickDelay());

        }
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

    }
    IEnumerator ClickDelay()
    {
        basilmamisobject.SetActive(false);
        basilmisobject.SetActive(true); 
        yield return new WaitForSeconds(0.2f);
        basilmisobject.SetActive(false);
        basilmamisobject.SetActive(true);
    }
}
