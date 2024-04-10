using UnityEngine;

public class Sound : MonoBehaviour
{
    public void Mute()
    {
        // T�m AudioSource bile�enlerini al
        AudioSource[] audioSources = FindObjectsOfType<AudioSource>();

        // Her bir AudioSource bile�enini etkinle�tir
        foreach (AudioSource source in audioSources)
        {
            source.enabled = true;
        }
    }

    public void Unmute()
    {
        // T�m AudioSource bile�enlerini al
        AudioSource[] audioSources = FindObjectsOfType<AudioSource>();

        // Her bir AudioSource bile�enini devre d��� b�rak
        foreach (AudioSource source in audioSources)
        {
            source.enabled = false;
        }
    }
}
