using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    [SerializeField] TextMeshProUGUI scoreText;

    public void AddScore(int points)
    {
        score += points;
        scoreText.text = score.ToString();
        Debug.Log("Tens " + score + " pontos.");
    }
}
