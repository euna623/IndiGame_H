using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject menuSet;

    bool isMenu = false;
    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (isMenu)
            {
                StartCoroutine(MenuSet_1());
            }
            else
            {
                StartCoroutine(MenuSet_2());
            }
        }
    }

    public void ReStarting()
    {
        StartCoroutine(MenuSet_1());
    }

    IEnumerator MenuSet_1()
    {
        menuSet.SetActive(false);
        yield return new WaitForSecondsRealtime(1f);
        Time.timeScale = 1;
    }

    IEnumerator MenuSet_2()
    {
        menuSet.SetActive(true);
        Time.timeScale = 0;
        yield return new WaitForSecondsRealtime(1f);
    }
    public void GameExit()
    {
        Application.Quit();
    }
}
