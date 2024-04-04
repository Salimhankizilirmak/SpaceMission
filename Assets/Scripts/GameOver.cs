using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject GameOverPanel;

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player1") == null)
        {
            GameOverPanel.SetActive(true);
        }
        else if (GameObject.FindGameObjectWithTag("Player2") == null)
        {
            GameOverPanel.SetActive(true);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("App Quit");
    }
    public void Back()
    {
        SceneManager.LoadScene("HomeScene");
    }
}