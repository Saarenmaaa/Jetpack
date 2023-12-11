using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject infoScreen;
    public void Quits()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Info()
    {
        infoScreen.SetActive(true);
    }
    public void Off()
    {
        infoScreen.SetActive(false);
    }

    public void reset()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();
    }
}
