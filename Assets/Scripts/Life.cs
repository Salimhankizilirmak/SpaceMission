using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Life : MonoBehaviour
{
    public TMP_Text lifeText;
    public int life;
    public GameObject messagePanel;
    public TMP_Text messageText;
    public float messageDuration = 1f; // Mesajın ekranda kalacağı süre
    public float gamePauseDuration = 1f;
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player1") != null && GameObject.FindGameObjectWithTag("Player2") != null)
        {

            lifeText.text = ((int)life).ToString();
        }
    }

    // 5 puan eklemek için fonksiyon
    public void LifeReduce()
    {
        life -= 1;
        
        lifeText.text = ((int)life).ToString();
        LoadNextLife();
    }
    public int GetLife()
    {
        return life;
    }
    public void LoadNextLife()
    {
        StartCoroutine(TransitionToNextLife());
    }
    IEnumerator TransitionToNextLife()
    {
        // Oyun hızını geçici olarak sıfırla
        Time.timeScale = 0f;

        // Mesajı göster
        messageText.text = "Be Carefull!! You have " + lifeText.text + " life left";
        messagePanel.SetActive(true);

        // Mesajın ekranda kalacağı süre kadar bekle
        yield return new WaitForSecondsRealtime(messageDuration);

        // Mesaj panelini gizle
        messagePanel.SetActive(false);

        // Oyun hızını geri al
        Time.timeScale = 1f;

        // Belirli bir süre oyunu duraklat
        yield return new WaitForSecondsRealtime(gamePauseDuration);

        // Oyunu devam ettir
        // Burada gerekli kodlar yer alacak, örneğin bir sonraki düşman dalgasını başlatmak veya başka bir eylemi gerçekleştirmek
    }
}

