using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassedMenu : MonoBehaviour
{

    public static bool passed = false;

    public GameObject passedMenuUI;

    void Update()
    {
        if (passed)
        {
            Passed();
        }
    }

    void Passed()
    {
        passedMenuUI.SetActive(true);
        Time.timeScale = 0f;
        passed = true;
    }

    public void NextLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        passed = false;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
        passed = false;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
