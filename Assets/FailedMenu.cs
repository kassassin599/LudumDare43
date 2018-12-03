using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FailedMenu : MonoBehaviour {

    public static bool failed = false;

    public GameObject failedMenuUI;

    void Update()
    {
        if (failed)
        {
            Failed();
        }
    }
    
    void Failed()
    {
        failedMenuUI.SetActive(true);
        Time.timeScale = 0f;
        failed = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
        failed = false;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
