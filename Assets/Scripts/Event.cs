using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Event : MonoBehaviour
{
    public GameObject SettingsPanel;
    public void Play()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("App Quit");
    }
    public void Settings()
    {
        SettingsPanel.SetActive(true);
    }
    public void QuitSettings()
    {
        SettingsPanel.SetActive(false);
    }
}