using UnityEngine;

public class Sound : MonoBehaviour
{
    public void Mute()
    {
        // Tüm AudioSource bileþenlerini al
        AudioSource[] audioSources = FindObjectsOfType<AudioSource>();

        // Her bir AudioSource bileþenini etkinleþtir
        foreach (AudioSource source in audioSources)
        {
            source.enabled = true;
        }
    }

    public void Unmute()
    {
        // Tüm AudioSource bileþenlerini al
        AudioSource[] audioSources = FindObjectsOfType<AudioSource>();

        // Her bir AudioSource bileþenini devre dýþý býrak
        foreach (AudioSource source in audioSources)
        {
            source.enabled = false;
        }
    }
}
