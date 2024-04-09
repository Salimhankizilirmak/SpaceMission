using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mars : MonoBehaviour
{
    private GameObject Player1;
    private GameObject Player2;
    public float Duration = 3f;
    private Win winScript;
    // Önceden atanmýþ patlama sesi dosyasý

    void Start()
    {
        Player1 = GameObject.FindGameObjectWithTag("Player1");
        Player2 = GameObject.FindGameObjectWithTag("Player2");
        winScript = GameObject.FindGameObjectWithTag("win").GetComponent<Win>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.tag == "Player1" || collision.tag == "Player2")
        {

            winScript.win();
            Destroy(Player2.gameObject);
            Destroy(Player1.gameObject);
            StartCoroutine(Stopped());

        }
     
    }
    IEnumerator Stopped()
    {
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(Duration);
        Time.timeScale = 1f;
    }


}
