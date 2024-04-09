using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameObject Player1;
    private GameObject Player2;
    private Life lifeScript;
    public float Duration = 3f;
    public AudioSource collisionSound; 

    void Start()
    {
        Player1 = GameObject.FindGameObjectWithTag("Player1");
        Player2 = GameObject.FindGameObjectWithTag("Player2");
        lifeScript = GameObject.FindGameObjectWithTag("LifeManager").GetComponent<Life>();
        collisionSound.enabled = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }

        else if (collision.tag == "Player1")
        {
            if (lifeScript.GetLife() > 0)
            {
                lifeScript.LifeReduce();
                Destroy(this.gameObject);

            }
            else if (lifeScript.GetLife() == 0)
            {
                
                Destroy(Player1.gameObject);
                
                StartCoroutine(Stopped());
                Destroy(Player2.gameObject);

            }
            collisionSound.Play(); // Patlama sesini çal}
        }
        else if (collision.tag == "Player2")
        {
            if (lifeScript.GetLife() > 0)
            {
                lifeScript.LifeReduce();
            }
            else if (lifeScript.GetLife() == 0)
            {
                Destroy(Player2.gameObject);
                StartCoroutine(Stopped());
                Destroy(Player1.gameObject);
            }
            collisionSound.Play(); // Patlama sesini çal
        }
    }
    IEnumerator Stopped()
    {
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(Duration);
        Time.timeScale = 1f;
    }


}
