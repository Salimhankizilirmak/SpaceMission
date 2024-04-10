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
    public float messageDuration = 2f; // Mesajýn ekranda kalacaðý süre
    public float gamePauseDuration = 1f;
   

    public void LoadNextLevel()
    {
        StartCoroutine(TransitionToNextLevel());
    }

    IEnumerator TransitionToNextLevel()
    {
        // Oyun hýzýný geçici olarak sýfýrla
        Time.timeScale = 0f;

        // Mesajý göster
        messageText.text = "Congratulations!!! You are in " + ((int)level) + ". level:))";
        messagePanel.SetActive(true);

        // Mesajýn ekranda kalacaðý süre kadar bekle
        yield return new WaitForSecondsRealtime(messageDuration);

        // Mesaj panelini gizle
        messagePanel.SetActive(false);

        // Oyun hýzýný geri al
        Time.timeScale = 1f;

        // Belirli bir süre oyunu duraklat
        yield return new WaitForSecondsRealtime(gamePauseDuration);

        // Oyunu devam ettir
        // Burada gerekli kodlar yer alacak, örneðin bir sonraki düþman dalgasýný baþlatmak veya baþka bir eylemi gerçekleþtirmek
    }
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player1") != null && GameObject.FindGameObjectWithTag("Player2") != null)
        {
            
            LevelText.text = ((int)level).ToString();
        }
    }

    // 5 puan eklemek için fonksiyon
    public void Add1Level()
    {
        level += 1;
        LoadNextLevel();
        LevelText.text = ((int)level).ToString();
        
    }
}
