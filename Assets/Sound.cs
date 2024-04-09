using UnityEngine;

public class Sound : MonoBehaviour
{
    

    // Tüm sesleri tekrar aç
    public void UnmuteGame()
    {
        // Tüm AudioListener bileþenlerini al
        AudioListener[] audioListeners = FindObjectsOfType<AudioListener>();

        // Her bir AudioListener bileþenini etkinleþtir
        foreach (AudioListener listener in audioListeners)
        {
            listener.enabled = true;
        }
    }
    public void MuteGame()
    { 
    // Tüm AudioListener bileþenlerini al
    AudioListener[] audioListeners = FindObjectsOfType<AudioListener>();

        // Her bir AudioListener bileþenini devre dýþý býrak
        foreach (AudioListener listener in audioListeners)
        {
            listener.enabled = false;
        }
}
}
