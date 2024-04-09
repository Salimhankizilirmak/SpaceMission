using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenTup : MonoBehaviour
{
    private GameObject Player1;
    private GameObject Player2;
    private Oxygen oxyScript;
   
    public AudioSource collisionSound;
    void Start()
    {
        Player1 = GameObject.FindGameObjectWithTag("Player1");
        Player2 = GameObject.FindGameObjectWithTag("Player2");
        collisionSound.enabled = true;
        // Score nesnesinin referansýný al
        oxyScript = GameObject.FindGameObjectWithTag("OxygenManager").GetComponent<Oxygen>();
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
            oxyScript.fullOxygen();
            collisionSound.Play();
            // Çarpýþma Player1 ile olduysa 5 puan ekle
        }
        else if (collision.tag == "Player2")
        {
            Destroy(this.gameObject);
            oxyScript.fullOxygen();
            collisionSound.Play();
            // Çarpýþma Player2 ile olduysa 5 puan ekle
        }
    }
  
}
