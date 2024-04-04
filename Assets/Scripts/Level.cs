using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Level : MonoBehaviour
{
    public TMP_Text LevelText;
    public float level;
    

   

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
        LevelText.text = ((int)level).ToString();
        
    }
}
