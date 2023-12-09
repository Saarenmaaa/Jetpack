using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartStop : MonoBehaviour
{
    public GameObject startButton;
    public GameObject stopButton;
    public AudioListener audioListener;

    void Start()
    {
        startButton.SetActive(false);
        stopButton.SetActive(true);
        audioListener.enabled = true;
    }

    public void StartButtonClick()
    {
        startButton.SetActive(false);
        stopButton.SetActive(true);

        Time.timeScale = 1f;
        audioListener.enabled = true;
    }

    public void StopButtonClick()
    {
        startButton.SetActive(true);
        stopButton.SetActive(false);
        Time.timeScale = 0f;

        audioListener.enabled = false;
    }
}
