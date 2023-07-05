using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;

    private void Start()
    {
        UpdateScoreText();
    }

    public void IncreaseScore(int pointsToAdd)
    {
        score += pointsToAdd;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}

