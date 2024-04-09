using UnityEngine;

public class Sound : MonoBehaviour
{
    

    // T�m sesleri tekrar a�
    public void UnmuteGame()
    {
        // T�m AudioListener bile�enlerini al
        AudioListener[] audioListeners = FindObjectsOfType<AudioListener>();

        // Her bir AudioListener bile�enini etkinle�tir
        foreach (AudioListener listener in audioListeners)
        {
            listener.enabled = true;
        }
    }
    public void MuteGame()
    { 
    // T�m AudioListener bile�enlerini al
    AudioListener[] audioListeners = FindObjectsOfType<AudioListener>();

        // Her bir AudioListener bile�enini devre d��� b�rak
        foreach (AudioListener listener in audioListeners)
        {
            listener.enabled = false;
        }
}
}
