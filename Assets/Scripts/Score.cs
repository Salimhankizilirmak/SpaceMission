using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text ScoreText;
    public float score;
    public TMP_Text highScore;
    public GameObject WinPanel;

    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
       
    }

    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player1") != null && GameObject.FindGameObjectWithTag("Player2") != null && !WinPanel.activeSelf)
        {
            score += 1 * Time.deltaTime;
            ScoreText.text = ((int)score).ToString();
            if (score > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", (int)score);
                highScore.text = score.ToString("0");
            }
        }
    }

    // 5 puan eklemek için fonksiyon
    public void Add5Points()
    {
        score += 5;
        ScoreText.text = ((int)score).ToString();
        CheckHighScore();
    }

    // 10 puan eklemek için fonksiyon
    public void Add10Points()
    {
        score += 10;
        ScoreText.text = ((int)score).ToString();
        CheckHighScore();
    }

    // Yüksek skoru kontrol etmek için yardýmcý fonksiyon
    void CheckHighScore()
    {
        if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", (int)score);
            highScore.text = score.ToString("0");
        }
    }
}
