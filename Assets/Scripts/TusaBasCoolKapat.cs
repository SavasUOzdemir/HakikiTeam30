using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TusaBasCoolKapat : MonoBehaviour
{
    public GameObject basilmisobject;
    public GameObject basilmamisobject;
    public GameObject settingsmenu;
    private void Awake()
    {
        basilmisobject.SetActive(false);
        basilmamisobject.SetActive(true);
    }
    public void PlayGame()
    {
        if (basilmisobject.activeSelf == false)
        {
            StartCoroutine(ClickDelay());
            settingsmenu.transform.LeanScale(new Vector3(0, 0, 0), 0.2f).setIgnoreTimeScale(true);

        }
    }
    IEnumerator ClickDelay()
    {
        basilmamisobject.SetActive(false);
        basilmisobject.SetActive(true);
        yield return new WaitForSecondsRealtime(0.2f);
        basilmisobject.SetActive(false);
        basilmamisobject.SetActive(true);
    }
    public void QuitGame()
    {
        if (basilmisobject.activeSelf == false)
        {
            StartCoroutine(ClickDelay());
            Application.Quit();
        }
    }
    public void SettingsPopIn()
    {
        if (basilmisobject.activeSelf == false)
        {
            StartCoroutine(ClickDelay());
            settingsmenu.transform.LeanScale(new Vector3(2, 2, 0), 0.2f).setIgnoreTimeScale(true);

        }
    }
}