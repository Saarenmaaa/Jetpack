using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartStop : MonoBehaviour
{
    public GameObject startButton;
    public GameObject stopButton;
    public GameObject stopScreen;
    public AudioListener audioListener;

    void Start()
    {
        startButton.SetActive(false);
        stopButton.SetActive(true);
        stopScreen.SetActive(false);
        audioListener.enabled = true;
    }

    public void StartButtonClick()
    {
        startButton.SetActive(false);
        stopButton.SetActive(true);
        stopScreen.SetActive(false);

        Time.timeScale = 1f;
        audioListener.enabled = true;
    }

    public void StopButtonClick()
    {
        startButton.SetActive(true);
        stopButton.SetActive(false);
        stopScreen.SetActive(true);
        Time.timeScale = 0f;

        audioListener.enabled = false;
    }
}
