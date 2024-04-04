using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    private GameObject Player1;
    private GameObject Player2;
    private Score scoreScript; // Score s�n�f�n�n referans�n� tutacak de�i�ken
    public AudioClip explosionSound;
    void Start()
    {
        Player1 = GameObject.FindGameObjectWithTag("Player1");
        Player2 = GameObject.FindGameObjectWithTag("Player2");

        // Score nesnesinin referans�n� al
        scoreScript = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<Score>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
        else if (collision.tag == "Player1")
        {
            Destroy(this.gameObject);
            scoreScript.Add5Points();
            PlayExplosionSound();// �arp��ma Player1 ile olduysa 5 puan ekle
        }
        else if (collision.tag == "Player2")
        {
            Destroy(this.gameObject);
            scoreScript.Add5Points();
            PlayExplosionSound();// �arp��ma Player2 ile olduysa 5 puan ekle
        }
    }
    void PlayExplosionSound()
    {
        // Patlama sesini �al
        if (explosionSound != null)
        {
            AudioSource.PlayClipAtPoint(explosionSound, transform.position);
        }
        else
        {
            Debug.LogWarning("Explosion sound is not assigned!");
        }
    }
}
