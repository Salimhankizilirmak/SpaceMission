using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Center : MonoBehaviour
{
    private GameObject Player1;
    private GameObject Player2;
    private Level LevelScript; // Score s�n�f�n�n referans�n� tutacak de�i�ken
    private Cameraman CameraSpeed;
    void Start()
    {
        Player1 = GameObject.FindGameObjectWithTag("Player1");
        Player2 = GameObject.FindGameObjectWithTag("Player2");
        CameraSpeed = GameObject.FindGameObjectWithTag("GameManager").GetComponent<Cameraman>();
        // Score nesnesinin referans�n� al
        LevelScript = GameObject.FindGameObjectWithTag("LevelManagement").GetComponent<Level>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
        else if (collision.tag == "Player1" || collision.tag == "Player2")
        {
            
            LevelScript.Add1Level();
            Destroy(this.gameObject);
            CameraSpeed.Add5Points();// �arp��ma Player1 ile olduysa 5 puan ekle
        }
        
    }
}