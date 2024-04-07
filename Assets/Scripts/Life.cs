using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Life : MonoBehaviour
{
    public TMP_Text lifeText;
    public int life;

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

    }
    public int GetLife()
    {
        return life;
    }
}
