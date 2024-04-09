using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Win : MonoBehaviour
{
    public GameObject WinPanel;
   public void win()
    {
        WinPanel.SetActive(true);
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
