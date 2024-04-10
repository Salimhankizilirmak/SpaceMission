using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Level : MonoBehaviour
{
    public TMP_Text LevelText;
    public float level;
    public GameObject messagePanel;
    public TMP_Text messageText;
    public float messageDuration = 2f; // Mesaj�n ekranda kalaca�� s�re
    public float gamePauseDuration = 1f;
   

    public void LoadNextLevel()
    {
        StartCoroutine(TransitionToNextLevel());
    }

    IEnumerator TransitionToNextLevel()
    {
        // Oyun h�z�n� ge�ici olarak s�f�rla
        Time.timeScale = 0f;

        // Mesaj� g�ster
        messageText.text = "Congratulations!!! You are in " + ((int)level) + ". level:))";
        messagePanel.SetActive(true);

        // Mesaj�n ekranda kalaca�� s�re kadar bekle
        yield return new WaitForSecondsRealtime(messageDuration);

        // Mesaj panelini gizle
        messagePanel.SetActive(false);

        // Oyun h�z�n� geri al
        Time.timeScale = 1f;

        // Belirli bir s�re oyunu duraklat
        yield return new WaitForSecondsRealtime(gamePauseDuration);

        // Oyunu devam ettir
        // Burada gerekli kodlar yer alacak, �rne�in bir sonraki d��man dalgas�n� ba�latmak veya ba�ka bir eylemi ger�ekle�tirmek
    }
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player1") != null && GameObject.FindGameObjectWithTag("Player2") != null)
        {
            
            LevelText.text = ((int)level).ToString();
        }
    }

    // 5 puan eklemek i�in fonksiyon
    public void Add1Level()
    {
        level += 1;
        LoadNextLevel();
        LevelText.text = ((int)level).ToString();
        
    }
}
