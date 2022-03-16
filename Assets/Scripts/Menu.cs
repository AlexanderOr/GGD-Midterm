using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject credits;
    public GameObject main;
    public void LoadLevel(string name)
    {
        PlayerPrefs.SetInt("Score", 0);
        SceneManager.LoadScene(name);
    }
    public void optionsmenu()
    {
        credits.SetActive(true);
        main.SetActive(false);
    }
    public void mainmenu()
    {
        credits.SetActive(false);
        main.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
