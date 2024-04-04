using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Oxygen : MonoBehaviour
{
    public Slider oxygen1Slider;
    public Slider oxygen2Slider;
    public float maxOxygen = 100f;
    public float oxygen;
    private float oxygenDecreaseTimer = 0f;
    private float oxygenDecreaseInterval = 1f; // Her saniye azaltma aralýðý
    public GameObject GameOverPanel;
    private GameObject Player1oxygen;
    private GameObject Player2oxygen;
    private GameObject Player1;
    private GameObject Player2;

    void Start()
    {
        oxygen = maxOxygen;
        Player1 = GameObject.FindGameObjectWithTag("Player1");
        Player2 = GameObject.FindGameObjectWithTag("Player2");
        Player1oxygen = GameObject.FindGameObjectWithTag("Player1Oxy");
        Player2oxygen = GameObject.FindGameObjectWithTag("player2Oxy");

    }

    void Update()
    {
        // Oksijen miktarýný kontrol et ve biten oyuncuyu yok et
        if (oxygen <= 0)
        {
            DestroyOxygenDepletedPlayer();
        }

        // Slider güncelleme
        UpdateOxygenSlider();

        // Her saniye oksijen azaltma iþlemi
        oxygenDecreaseTimer += Time.deltaTime;
        if (oxygenDecreaseTimer >= oxygenDecreaseInterval)
        {
            downOxygen(10);
            oxygenDecreaseTimer = 0f;
        }
    }

    void UpdateOxygenSlider()
    {
        // Slider'ý güncelle
        oxygen1Slider.value = oxygen;
        oxygen2Slider.value = oxygen;
    }

    void downOxygen(float down)
    {
        oxygen -= down;
    }
    public void fullOxygen()
    {
        // Oxygen değerini maxOxygen değerine eşitle
        oxygen = maxOxygen;
    }

    void DestroyOxygenDepletedPlayer()
    {
        // Oksijeni biten oyuncuyu yok et
        if (Player1oxygen != null && oxygen <= 0)
        {
            Destroy(Player1);
        }
        else if (Player2oxygen != null && oxygen <= 0)
        {
            Destroy(Player2);
        }

        // Game Over panelini aktifleþtir
        GameOverPanel.SetActive(true);
    }
}