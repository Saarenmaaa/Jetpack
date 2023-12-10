using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public TMP_Text attemptText;
    private int attempts = 0;

    void Start()
    {
        attempts = PlayerPrefs.GetInt("AttemptCount", 0);
        UpdateAttemptText();
    }

    void UpdateAttemptText()
    {
        if (attemptText != null)
        {
            attemptText.text = "Attempt " + attempts;
        }
    }

    public void IncrementAttempt()
    {
        attempts++;
        UpdateAttemptText();
    }

    public void ResetAttempts()
    {
        attempts = 0;
        UpdateAttemptText();
    }

    void OnDisable()
    {
        PlayerPrefs.SetInt("AttemptCount", attempts);
        PlayerPrefs.Save();
    }

    public void Quit()
    {
        Application.Quit();
    }
}
