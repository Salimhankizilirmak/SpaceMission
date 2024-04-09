using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject GameOverPanel;
    public GameObject SettingPanel;
    private Life lifeScript;
    // Update is called once per frame
    void Start()
    {
        lifeScript = GameObject.FindGameObjectWithTag("LifeManager").GetComponent<Life>();
    }
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player1") == null && lifeScript.GetLife() <= 0)
        {
            GameOverPanel.SetActive(true);
        }
        else if (GameObject.FindGameObjectWithTag("Player2") == null && lifeScript.GetLife() <= 0)
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
    public void Setting()
    {
        SettingPanel.SetActive(true);
    }
    public void SettingQuit()
    {
        SettingPanel.SetActive(false);
    }
}